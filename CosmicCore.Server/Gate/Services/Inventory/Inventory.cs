using System.Collections;
using CosmicCore.Protos;
using CosmicCore.Server.Gate.Services.Utils;
using CosmicCore.Server.Utilities;
using CosmicCore.Server.Utilities.Account;
using CosmicCore.Server.Utilities.Resource;
using CosmicCore.Server.Utilities.Resource.Resources;

namespace CosmicCore.Server.Gate.Services.Inventory;

// TODO
public class Inventory : AccountManager
{
    public Dictionary<int, Item> Storage { get; } = [];
    public Dictionary<InventoryTabType, InventoryTab> InventoryTabs = new()
    {
        { InventoryTabType.EQUIPMENT, new EquipInventoryTab(Const.InventoryMaxEquipment) },
        { InventoryTabType.RELIC, new EquipInventoryTab(Const.InventoryMaxRelic) },
        { InventoryTabType.MATERIAL, new EquipInventoryTab(Const.InventoryMaxMaterial) }
    };

    private int _nextInternalId = 10000;

    public int NextInternalId
    {
        get
        {
            _nextInternalId += 1;
            return _nextInternalId;
        }
    }

    public Inventory(Account account) : base(account)
    {
    }

    public Item? this[ItemParam param]
    {
        get
        {
            if (param.Type == ItemParamType.Pile)
            {
                return InventoryTabs[InventoryTabType.MATERIAL][param.Id];
            }

            if (param.Type == ItemParamType.Unique)
            {
                return Storage[param.Id];
            }

            return null;
        }
    }

    public bool AddItem(int itemId, int amount)
    {
        var itemExcel = ResourceManager.ItemExcels.First(itm => itm.Id == itemId);
        var item = new Item(itemExcel, amount);
        item.Excel ??= itemExcel;
        return AddItemAndUpdate(item);
    }

    public bool AddItem(Item item, int amount = 1)
    {
        var itemExcel = ResourceManager.ItemExcels.First(itm => itm.Id == item.ItemId);
        item.Excel ??= itemExcel;
        return AddItemAndUpdate(item);
    }

    private bool AddItemAndUpdate(Item item)
    {
        var result = AddItemInInventory(item);

        if (result is not null)
        {
            Owner.Session.Send(CmdId.CmdPlayerSyncScNotify, new PlayerSyncScNotify().AddItem(item));
            return true;
        }

        return false;
    }

    private Item? AddItemInInventory(Item item)
    {
        if (item.Excel is null)
        {
            return null;
        }

        var type = item.Excel.ItemMainType;
        var subType = item.Excel.ItemSubType;
        var tab = InventoryTabs.TryGetValue(type.TabType());
        switch (type)
        {
            case ItemMainType.Equipment:
            case ItemMainType.Relic:
                if (tab.AvailableCapacity <= 0)
                {
                    return null;
                }

                item.Count = 1;
                AddItem(item, tab);
                return item;
            case ItemMainType.Virtual:
                AddVirtualItem(item.ItemId, item.Count);
                return item;
            case ItemMainType.AvatarCard:
                var avatarExcel = ResourceManager.AvatarExcels.First(ava => ava.Id == item.ItemId);
                if (!Owner.AvatarInventory.Avatars.ContainsKey(avatarExcel.Id))
                {
                    Owner.AvatarInventory.AddAvatar(new Avatar(avatarExcel));
                }

                return null;
            case ItemMainType.Usable:
                switch (subType)
                {
                    case ItemSubType.HeadIcon:
                        Owner.Unlocks.AddHeadIcon(item.ItemId);
                        return item;
                    case ItemSubType.ChatBubble:
                        Owner.Unlocks.AddChatBubble(item.ItemId);
                        return item;
                    case ItemSubType.PhoneTheme:
                        Owner.Unlocks.AddPhoneTheme(item.ItemId);
                        return item;
                }

                if (subType != ItemSubType.Food)
                {
                    return null;
                }

                break;
            default:
                if (tab is null)
                {
                    return null;
                }

                var existingItem = tab[item.ItemId];

                if (existingItem is null)
                {
                    if (tab.AvailableCapacity <= 0)
                    {
                        return null;
                    }

                    AddItem(item, tab);
                    return item;
                }
                else
                {
                    var amnt = Number.SafeAdd(existingItem.Count, item.Count, 0, item.Excel.PileLimit);
                    existingItem.Count = amnt;
                    return item;
                }
        }

        return null; // should not happen
    }

    public void AddItem(Item item, InventoryTab? tab)
    {
        item.Owner = Owner;

        if (tab is not null)
        {
            Storage.Add(item.InternalId, item);
            tab.AddItem(item);
        }
    }

    public void AddVirtualItem(int id, int amount)
    {
        switch (id)
        {
            case 1:
                Owner.Currency.HCoin += amount;
                break;
            case 2:
                Owner.Currency.SCoin += amount;
                break;
            case 3:
                Owner.Currency.MCoin += amount;
                break;
            case 11:
                Owner.Stamina += amount;
                break;
            case 22:
                Owner.Experience += amount;
                break;
            // TODO: case rogue talent point
        }
    }

    public bool RemoveItem(Item? item, int amount)
    {
        if (amount <= 0 || item is null || item.Owner != Owner)
        {
            return false;
        }

        if (item.Excel is null || item.Excel.IsEquipable)
        {
            item.Count = 0;
        }
        else
        {
            item.Count = Number.SafeSubtract(item.Count, amount);
        }

        if (item.Count <= 0)
        {
            if (item.Excel is not null)
            {
                if (InventoryTabs.TryGetValue(item.Excel.ItemMainType.TabType(), out var tab))
                {
                    tab.RemoveItem(item);
                }
            }

            Storage.Remove(item.InternalId);
        }

        Owner.Session.Send(CmdId.CmdPlayerSyncScNotify, new PlayerSyncScNotify().AddItem(item));

        return true;
    }
}

public abstract class InventoryTab : IEnumerable<Item>
{
    public abstract Item? this[int id] { get; }
    public abstract int MaxCapacity { get; }
    public abstract int AvailableCapacity { get; }
    public abstract void AddItem(Item item);
    public abstract void RemoveItem(Item item);

    public abstract IEnumerator<Item> GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

public class EquipInventoryTab(int maxCapacity) : InventoryTab
{
    private HashSet<Item> _equips = [];

    public override Item? this[int id] => null;

    public override int MaxCapacity { get; } = maxCapacity;
    public override int AvailableCapacity => Math.Max(MaxCapacity - _equips.Count, 0);

    public override void AddItem(Item item)
    {
        _equips.Add(item);
    }

    public override void RemoveItem(Item item)
    {
        _equips.Remove(item);
    }

    public override IEnumerator<Item> GetEnumerator()
    {
        return _equips.GetEnumerator();
    }
}

public class MaterialInventoryTab(int maxCapacity) : InventoryTab
{
    private Dictionary<int, Item> _materials = [];

    public override Item? this[int id]
    {
        get
        {
            if (_materials.TryGetValue(id, out var item))
            {
                return item;
            }
            else
            {
                return null;
            }
        }
    }

    public override int MaxCapacity { get; } = maxCapacity;
    public override int AvailableCapacity => Math.Max(MaxCapacity - _materials.Count, 0);

    public override void AddItem(Item item)
    {
        _materials.Add(item.ItemId, item);
    }

    public override void RemoveItem(Item item)
    {
        _materials.Remove(item.ItemId);
    }

    public override IEnumerator<Item> GetEnumerator()
    {
        return _materials.Values.GetEnumerator();
    }
}

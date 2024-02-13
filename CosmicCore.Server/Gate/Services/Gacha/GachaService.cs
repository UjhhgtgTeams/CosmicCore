using CosmicCore.Protos;
using CosmicCore.Server.Utilities;
using CosmicCore.Server.Utilities.Account;
using CosmicCore.Server.Utilities.Resource;
using CosmicCore.Server.Utilities.Resource.Resources;
using Newtonsoft.Json;
using Serilog;
using Item = CosmicCore.Server.Gate.Services.Inventory.Item;
using Random = CosmicCore.Server.Utilities.Random;

namespace CosmicCore.Server.Gate.Services.Gacha;

public static class GachaService
{
    private static readonly Dictionary<int, GachaBanner> GachaBanners = [];
    private static readonly System.Random RandomGen = new();

    // TODO: remove hardcode values
    public static readonly int[] DefaultYellowAvatars = [1003, 1004, 1101, 1107, 1104, 1209, 1211];
    public static readonly int[] DefaultYellowWeapons = [23000, 23002, 23003, 23004, 23005, 23012, 23013];

    public static readonly int[] DefaultPurpleAvatars =
    [
        1001, 1002, 1008, 1009, 1013, 1103, 1105, 1106, 1108, 1109, 1110, 1111, 1201, 1202, 1206, 1207, 1210
    ];

    public static readonly int[] DefaultPurpleWeapons =
    [
        21000, 21001, 21002, 21003, 21004, 21005, 21006, 21007, 21008, 21009, 21010, 21011, 21012, 21013, 21014, 21015,
        21016, 21017, 21018, 21019, 21020
    ];

    public static readonly int[] DefaultBlueWeapons =
    [
        20000, 20001, 20002, 20003, 20004, 20005, 20006, 20007, 20008, 20009, 20010, 20011, 20012, 20013, 20014, 20015,
        20016, 20017, 20018, 20019, 20020
    ];

    public static readonly int[] DefaultFeaturedIds = [23002, 1003, 1101, 1104, 23000, 23003];

    public const int EmbersId = 251;
    public const int StarlightId = 252;

    public static void Initialize(StringPath path)
    {
        Log.Information("Loading gacha banners...");
        var banners = JsonConvert.DeserializeObject<List<GachaBanner>>(path) ?? [];
        foreach (var banner in banners)
        {
            GachaBanners.Add(banner.Id, banner);
        }
        Log.Information("{0} gacha banners loaded from {1}", banners.Count, path);
    }

    public static void PerformPull(Account account, int gachaId, int gachaAmount)
    {
        if (gachaAmount != 10 && gachaAmount != 1)
            return;

        if (account.Inventory.InventoryTabs[InventoryTabType.EQUIPMENT].AvailableCapacity <= 0)
        {
            account.Session.Send(CmdId.CmdDoGachaScRsp, new DoGachaScRsp
            {
                Retcode = (uint)Retcode.EquipmentExceedLimit
            });
            return;
        }

        if (!GachaBanners.TryGetValue(gachaId, out GachaBanner banner))
        {
            account.Session.Send(CmdId.CmdDoGachaScRsp, new DoGachaScRsp
            {
                Retcode = (uint)Retcode.GachaIdNotExist
            });
            return;
        }

        if (banner.GachaType.CostItem() > 0)
        {
            var costItem = account.Inventory.InventoryTabs[InventoryTabType.MATERIAL][banner.GachaType.CostItem()];

            if (costItem is null || costItem.Count < gachaAmount)
            {
                account.Session.Send(CmdId.CmdDoGachaScRsp, new DoGachaScRsp
                {
                    Retcode = (uint)Retcode.Failed
                });
            }

            account.Inventory.RemoveItem(costItem, gachaAmount);
        }

        if (banner.GachaType == GachaType.Normal || banner.GachaType == GachaType.Newbie)
        {
            account.Gacha.Ceiling += gachaAmount;
        }

        var gachaInfo = account.Gacha.GetBannerInfo(banner.GachaType);
        var wonItems = new List<int>();

        // TODO: i probably need to look into this algorithm more...
        for (var i = 0; i <= gachaAmount - 1; i++)
        {
            var random = GetRandom(1, 10000);
            var itemId = 0;

            var bonusYellowChance = gachaInfo.Pity5 >= 74 ? 100 * (gachaInfo.Pity5 - 73) : 0;
            var yellowChance = 60 + (int)Math.Floor(100f * (gachaInfo.Pity5 / 73f)) + bonusYellowChance;
            var purpleChance = 10000 - (510 + (int)Math.Floor(790f * (gachaInfo.Pity4 / 8f)));

            if (random <= yellowChance || gachaInfo.Pity5 >= 89)
            {
                if (banner.RateUpItems5.Count > 0)
                {
                    var eventChance = GetRandom(1, 100);

                    if (eventChance <= banner.EventChance || gachaInfo.FailedFeaturedItemPulls >= 1)
                    {
                        itemId = Random.FromList(banner.RateUpItems5);
                        gachaInfo.FailedFeaturedItemPulls = 0;
                    }
                    else
                    {
                        gachaInfo.FailedFeaturedItemPulls += 1;
                    }
                }

                if (itemId == 0)
                {
                    var typeChance = GetRandom(banner.GachaType.Min(), banner.GachaType.Max());

                    if (typeChance == 1)
                    {
                        itemId = Random.FromList(DefaultYellowAvatars.ToList());
                    }
                    else
                    {
                        itemId = Random.FromList(DefaultYellowWeapons.ToList());
                    }
                }

                gachaInfo.Pity5 = 0;
                gachaInfo.Pity4 += 1;
            }
            else if (random >= purpleChance || gachaInfo.Pity4 >= 9)
            {
                if (banner.RateUpItems4.Count > 0)
                {
                    var eventChance = GetRandom(1, 100);

                    if (eventChance >= 50)
                    {
                        itemId = Random.FromList(banner.RateUpItems4);
                    }
                }

                if (itemId == 0)
                {
                    var typeChance = GetRandom(banner.GachaType.Min(), banner.GachaType.Max());

                    if (typeChance == 1)
                    {
                        itemId = Random.FromList(DefaultPurpleAvatars.ToList());
                    }
                    else
                    {
                        itemId = Random.FromList(DefaultPurpleWeapons.ToList());
                    }
                }

                gachaInfo.Pity5 += 1;
                gachaInfo.Pity4 = 0;
            }
            else
            {
                itemId = Random.FromList(DefaultBlueWeapons.ToList());

                gachaInfo.Pity5 += 1;
                gachaInfo.Pity4 += 1;
            }

            wonItems.Add(itemId);
        }

        var itemList = new List<GachaItem>();
        var embers = 0;
        var starlight = 0;

        foreach (var itemId in wonItems)
        {
            var itemData = ResourceManager.ItemExcels.First(it => it.Id == itemId);
            var gachaItem = new GachaItem
            {
                TransferItemList = new ItemList(),
                TokenItem = new ItemList()
            };
            var addEmbers = 0;
            var addStarlight = 0;

            if (itemData.ItemMainType == ItemMainType.AvatarCard)
            {
                var avatarId = itemData.Id;
                if (account.AvatarInventory.Avatars.TryGetValue(avatarId, out var avatar))
                {
                    var dupeLevel = avatar.Data.Rank;
                    var dupeItemId = avatar.Excel.RankUpItemId;
                    var dupeItem =
                        account.Inventory.InventoryTabs[InventoryTabType.MATERIAL][avatar.Excel.RankUpItemId];
                    if (dupeItem is not null)
                    {
                        dupeLevel += dupeItem.Count;
                    }

                    if (dupeLevel < 6)
                    {
                        addStarlight = 8;
                        gachaItem.TransferItemList.ItemsList.Add(new Protos.Item
                        {
                            ItemId = (uint)dupeItemId,
                            Num = 1
                        });
                        account.Inventory.AddItem(dupeItemId, 1);
                    }
                    else
                    {
                        addStarlight = 20;
                    }

                    if (itemData.Rarity == ItemRarity.SuperRare)
                    {
                        addStarlight *= 5;
                    }
                }
                else
                {
                    gachaItem.IsNew = true;
                }
            }
            else
            {
                switch (itemData.Rarity)
                {
                    case ItemRarity.SuperRare:
                        addStarlight = 40;
                        break;
                    case ItemRarity.VeryRare:
                        addStarlight = 8;
                        break;
                    case ItemRarity.Rare:
                        addEmbers = 20;
                        break;
                }
            }

            var item = new Item(itemData);
            gachaItem.gacha_item = item.ToProto();
            account.Inventory.AddItem(item);

            embers += addEmbers;
            starlight += addStarlight;

            if (addEmbers > 0)
            {
                gachaItem.TokenItem.ItemsList.Add(new Protos.Item
                {
                    ItemId = (uint)EmbersId,
                    Num = (uint)addEmbers
                });
            }

            if (addStarlight > 0)
            {
                gachaItem.TokenItem.ItemsList.Add(new Protos.Item
                {
                    ItemId = (uint)StarlightId,
                    Num = (uint)addStarlight
                });
            }

            itemList.Add(gachaItem);
        }

        if (embers > 0)
        {
            account.Inventory.AddItem(EmbersId, embers);
        }

        if (starlight > 0)
        {
            account.Inventory.AddItem(StarlightId, starlight);
        }

        var packet = new DoGachaScRsp
        {
            GachaNum = (uint)gachaAmount,
            CeilingNum = (uint)(account.Gacha.Ceiling ?? Const.MaxGachaCeiling /* need verification */),
            GachaId = (uint)banner.Id
        };
        packet.GachaItemList.AddRange(itemList);
        account.Session.Send(CmdId.CmdDoGachaScRsp, packet);
    }

    public static Item? PerformExchangeCeiling(Account account, int avatarId)
    {
        if (account.Gacha.Ceiling is null || account.Gacha.Ceiling < Const.MaxGachaCeiling || !DefaultYellowAvatars.Contains(avatarId))
        {
            return null;
        }

        var avatarItem = account.AvatarInventory.HasAvatar(avatarId) ? new Item(avatarId + 10000) : new Item(avatarId);
        account.Inventory.AddItem(avatarItem);
        account.Gacha.Ceiling = null;

        return avatarItem;
    }

    private static int GetRandom(int min, int max) // weird random function in original code
    {
        return RandomGen.Next(max - min + 1) + min;
    }
}

using CosmicCore.Protos;

namespace CosmicCore.Server.Gate.Services.Inventory;

public class ItemParam
{
    public int Id { get; }
    public int Count { get; }
    public ItemParamType Type { get; } = ItemParamType.Pile;

    public ItemParam()
    {
    }

    public ItemParam(int id, int count)
    {
        Id = id;
        Count = count;
    }

    public ItemParam(ItemParamType type, int id, int count)
    {
        Type = type;
        Id = id;
        Count = count;
    }

    public ItemParam(ItemCost itemCost)
    {
        if (itemCost.PileItem is not null)
        {
            Id = (int)itemCost.PileItem.ItemId;
            Count = (int)itemCost.PileItem.ItemNum;
        }
        else if (itemCost.EquipmentUniqueId != 0)
        {
            Type = ItemParamType.Unique;
            Id = (int)itemCost.EquipmentUniqueId;
            Count = 1;
        }
        else if (itemCost.RelicUniqueId != 0)
        {
            Type = ItemParamType.Unique;
            Id = (int)itemCost.RelicUniqueId;
            Count = 1;
        }
    }
}

public enum ItemParamType
{
    Unknown,
    Pile,
    Unique
}

using CosmicCore.Server.Gate.Services.Inventory;
using Newtonsoft.Json;

namespace CosmicCore.Server.Utilities.Resource.Resources;

[Resource(FileNames =
[
    "ItemConfig.json", "ItemConfigAvatar.json", "ItemConfigAvatarPlayerIcon.json", "ItemConfigAvatarRank.json",
    "ItemConfigBook.json", "ItemConfigDisk.json", "ItemConfigEquipment.json", "ItemConfigRelic.json", "ItemPlayerCard.json"
])]
public class ItemExcel : IResource
{
    public override int Id => ID;
    public int ID { get; set; }
    public HashedName ItemName { get; set; }
    public ItemMainType ItemMainType { get; set; } = ItemMainType.Unknown;
    public ItemSubType ItemSubType { get; set; } = ItemSubType.Unknown;
    public ItemRarity Rarity { get; set; }
    public int PileLimit { get; set; }
    public int PurposeType { get; set; }

    [JsonProperty("UseDataID")]
    public int UseDataId { get; set; }
    public ItemUseMethod UseMethod { get; set; }

    [JsonProperty("ReturnItemIDList")]
    public List<ItemParam> ReturnItemIdList { get; set; }

    [JsonIgnore] public EquipmentExcel? EquipmentExcel { get; set; }
    [JsonIgnore] public RelicExcel? RelicExcel { get; set; }

    public int AvatarExp { get; set; }
    public int RelicExp { get; set; }
    public int EquipmentExp { get; set; }
    public int ExpCost { get; set; }

    public bool IsEquipment => ItemMainType == ItemMainType.Equipment && EquipmentExcel is not null;
    public bool IsRelic => ItemMainType == ItemMainType.Relic && RelicExcel is not null;
    public bool IsEquipable => ItemMainType == ItemMainType.Equipment || ItemMainType == ItemMainType.Relic;

    public int EquipSlot
    {
        get
        {
            if (RelicExcel is not null)
            {
                return (int)RelicExcel.Type;
            }
            if (EquipmentExcel is not null)
            {
                return 100;
            }
            return 0;
        }
    }

    public override void OnLoad() { }
}

// ReSharper disable InconsistentNaming
public enum ItemMainType
{
    Unknown = 0,
    Virtual = 1,
    AvatarCard = 2,
    Equipment = 3,
    Relic = 4,
    Usable = 5,
    Material = 6,
    Mission = 7,
    Display = 8
}

public static class ItemMainTypeExtensionMethods
{
    public static InventoryTabType TabType(this ItemMainType type)
    {
        return type switch
        {
            ItemMainType.Equipment => InventoryTabType.EQUIPMENT,
            ItemMainType.Relic => InventoryTabType.RELIC,
            ItemMainType.Usable => InventoryTabType.MATERIAL,
            ItemMainType.Material => InventoryTabType.MATERIAL,
            ItemMainType.Mission => InventoryTabType.MATERIAL,
            _ => InventoryTabType.NONE
        };
    }
}

public enum InventoryTabType
{
    NONE,
    MATERIAL,
    EQUIPMENT,
    RELIC
}

public enum ItemSubType
{
    Unknown = 0,
    Virtual = 101,
    GameplayCounter = 102,
    AvatarCard = 201,
    Equipment = 301,
    Relic = 401,
    Gift = 501,
    Food = 502,
    ForceOpitonalGift = 503, // darn mihoyo
    Book = 504,
    HeadIcon = 505,
    MusicAlbum = 506,
    Formula = 507,
    ChatBubble = 508,
    PhoneTheme = 510,
    Material = 601,
    Eidolon = 602,
    MuseumExhibit = 603,
    MuseumStuff = 604,
    Mission = 701,
    RelicSetShowOnly = 801,
    RelicRarityShowOnly = 802,
    TravelBrochurePaster = 990, // FIXME: what's the id?
    AetherSkill = 991,
    AetherSpirit = 992,
    ChessRogueDiceSurface = 993
}

public enum ItemRarity
{
    Unknown,
    Normal,
    NotNormal,
    Rare,
    VeryRare,
    SuperRare
}

public enum ItemUseMethod
{
    Unknown = 0,
    FixedRewardGift = 101,
    RandomRewardGift = 102,
    PlayerSelectedReward = 103,
    TeamFoodBenefit = 201,
    TeamSpecificFoodBenefit = 202,
    ExternalSystemFoodBenefit = 203,
    PlayerSelectedDropGift = 301,
    TreasureMap = 401,
    Recipe = 501,
    PerformanceProp = 601,
    MonthlyCard = 701,
    BPUnlock68 = 702,
    BPUnlock128 = 703,
    BPUpgradeFrom68To128 = 704,
    AutoConversionItem = 801,
    TravelBrochureUse = 998, // FIXME: what's the id?
    TravelBrochurePasterUse = 999
}

namespace CosmicCore.Server.Utilities.Resource.Resources;

[Resource(FileNames =
[
    "ItemConfig.json", "ItemConfigAvatar.json", "ItemConfigAvatarPlayerIcon.json", "ItemConfigAvatarRank.json",
    "ItemConfigBook.json", "ItemConfigDisk.json", "ItemConfigEquipment.json", "ItemConfigRelic.json", "ItemPlayerCard.json"
])]
public class ItemExcel : IResource
{
    public int ID { get; }
    public long ItemName { get; }
    public ItemMainType ItemMainType { get; } = ItemMainType.Unknown;
    public ItemSubType ItemSubType { get; } = ItemSubType.Unknown;
    public ItemRarity Rarity { get; }
    public int PileLimit { get; }
    public int PurposeType { get; }
    public int UseDataID { get; }
    public int AvatarExp { get; }
    public int RelicExp { get; }
    public int EquipmentExp { get; }
    public int ExpCost { get; }

    public override int Id => ID;

    public override void OnLoad()
    {
        // Implement if necessary
    }
}

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
    // ReSharper disable InconsistentNaming
    NONE,
    MATERIAL,
    EQUIPMENT,
    RELIC
    // ReSharper restore InconsistentNaming
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
    // ReSharper disable IdentifierTypo
    ForceOpitonalGift = 503, // darn mihoyo
    // ReSharper restore IdentifierTypo
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
    RelicRarityShowOnly = 802
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

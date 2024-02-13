using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CosmicCore.Server.Utilities.Resource.Resources;

[Resource(FileNames = ["AvatarConfig.json"])]
public partial class AvatarExcel : IResource
{
    public override int Id => AvatarId;
    public int RankUpItemId => AvatarId + 10000;

    [JsonProperty("AvatarID")]
    public int AvatarId { get; set; }
    [JsonProperty]
    public HashedName AvatarName { get; set; }
    [JsonConverter(typeof(StringEnumConverter))]
    public DamageType DamageType { get; set; }
    [JsonConverter(typeof(StringEnumConverter))]
    public AvatarBaseType AvatarBaseType { get; set; }

    public int ExpGroup { get; set; }
    public int MaxPromotion { get; set; }
    public int MaxRank { get; set; }

    public List<int> RankIdList { get; set; }
    public List<int> SkillList { get; set; }
    public string JsonPath { get; set; }

    [JsonIgnore] public AvatarPromotionExcel[] PromotionData { get; set; }
    [JsonIgnore] public List<AvatarSkillTreeExcel> DefaultSkillTrees { get; set; } = [];
    [JsonIgnore] public HashSet<int> SkillTreeIds { get; set; } = [];
    [JsonIgnore] public string NameKey { get; set; }
    [JsonIgnore] public int HeadIconId => Id + 200000;

    public int GetRankId(int rank)
    {
        return RankIdList[Math.Min(rank, RankIdList.Count - 1)];
    }

    public override void OnLoad()
    {
        PromotionData = new AvatarPromotionExcel[MaxPromotion + 1];
        for (var i = 0; i <= MaxPromotion; i++)
        {
            PromotionData[i] = ResourceManager.AvatarPromotionExcels.First(pm => pm.Id == (Id << 8) + 1);
        }

        NameKey = NameRegex().Match(JsonPath).Groups[1].Value;
    }

    [GeneratedRegex("(?<=Avatar_)(.*?)(?=_Config)")]
    private static partial Regex NameRegex();
}

public enum DamageType
{
    Physical = 1000111,
    Fire = 1000112,
    Ice = 1000113,
    Thunder = 1000114,
    Wind = 1000115,
    Quantum = 1000116,
    Imaginary = 1000117
}

public static class DamageTypeExtensionMethods
{
    public static long TextMapHash(this DamageType type)
    {
        return type switch
        {
            DamageType.Physical => -1101149179,
            DamageType.Fire => -1474263915,
            DamageType.Ice => -756819502,
            DamageType.Thunder => -250814279,
            DamageType.Wind => -1513894875,
            DamageType.Quantum => 88513016,
            DamageType.Imaginary => 118034640,
            _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
        };
    }
}

public enum AvatarBaseType
{
    Unknown = 0,
    Warrior = 1, // destruction
    Rogue = 2, // hunt
    Mage = 3, // erudition
    Shaman = 4, // harmony
    Warlock = 5, // nihility
    Knight = 6, // preservation
    Priest = 7 // abundance
}

public static class AvatarBaseTypeExtensionMethods
{
    public static long TextMapHash(this AvatarBaseType type)
    {
        return type switch
        {
            AvatarBaseType.Unknown => 750427067, // just took a random text entry whose text is "unknown"
            AvatarBaseType.Warrior => 209078842,
            AvatarBaseType.Rogue => 612363369,
            AvatarBaseType.Mage => -953720572,
            AvatarBaseType.Shaman => -194205685,
            AvatarBaseType.Warlock => -1760289626,
            AvatarBaseType.Knight => -1357005099,
            AvatarBaseType.Priest => 1371878256,
            _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
        };
    }
}

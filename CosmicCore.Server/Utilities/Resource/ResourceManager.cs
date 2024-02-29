using System.Reflection;
using CosmicCore.Server.Utilities.Locale;
using CosmicCore.Server.Utilities.Resource.Resources;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Serilog;

namespace CosmicCore.Server.Utilities.Resource;

public static class ResourceManager
{
    public static List<AvatarExcel> AvatarExcels { get; private set; } = [];
    public static List<AvatarPromotionExcel> AvatarPromotionExcels { get; private set; } = [];
    public static List<AvatarSkillTreeExcel> AvatarSkillTreeExcels { get; private set; } = [];
    public static List<ChatBubbleExcel> ChatBubbleExcels { get; private set; } = [];
    public static List<EquipmentExcel> EquipmentExcels { get; private set; } = [];
    public static List<HeroExcel> HeroExcels { get; private set; } = [];
    public static List<ItemExcel> ItemExcels { get; private set; } = [];
    public static List<MazePlaneExcel> MazePlaneExcels { get; private set; } = [];
    public static List<NpcMonsterExcel> NpcMonsterExcels { get; private set; } = [];
    public static List<PhoneThemeExcel> PhoneThemeExcels { get; private set; } = [];
    public static List<PropExcel> PropExcels { get; private set; } = [];
    public static List<RelicExcel> RelicExcels { get; private set; } = [];
    public static Dictionary<int, List<RelicMainAffixExcel>> RelicMainAffixExcels { get; private set; } = [];
    public static Dictionary<int, List<RelicSubAffixExcel>> RelicSubAffixExcels { get; private set; } = [];
    public static List<ShopExcel> ShopExcels { get; private set; } = [];
    public static List<ShopGoodsExcel> ShopGoodsExcels { get; private set; } = [];
    public static List<StageExcel> StageExcels { get; private set; } = [];
    public static Dictionary<long, string> TextMap { get; private set; } = [];
    // public static Dictionary<string, FloorInfo> FloorInfos { get; private set; }

    /// <summary>
    /// Load all resources (configs, excels and text maps) from resource directory.
    /// </summary>
    /// <param name="dirPath">Directory of resources.</param>
    /// <returns>A boolean indicating whether resources are all loaded.</returns>
    public static bool LoadResources(StringPath dirPath)
    {
        Log.Information("Loading resources...");
        if (Directory.Exists(dirPath))
        {
            LoadExcels(dirPath);
            LoadTextMap(dirPath);
            Log.Information("All resources loaded");
        }
        else
        {
            Log.Warning("Resources not found! Please place resources under {0}", dirPath);
        }

        return Directory.Exists(dirPath);
    }

    public static string GetTextMapEntry(long id)
    {
        return TextMap.GetValueOrDefault(id, "null");
    }

    private static void LoadExcels(StringPath path)
    {
        // TODO: handle load priority
        // highest
        AvatarPromotionExcels = LoadAvatarInfoExcel<AvatarPromotionExcel>(path);
        // high
        // normal
        AvatarExcels = LoadExcel<AvatarExcel>(path);
        HeroExcels = LoadExcel<HeroExcel>(path);
        ItemExcels = LoadExcel<ItemExcel>(path);
        MazePlaneExcels = LoadExcel<MazePlaneExcel>(path);
        NpcMonsterExcels = LoadExcel<NpcMonsterExcel>(path);
        PropExcels = LoadExcel<PropExcel>(path);
        RelicMainAffixExcels = LoadRelicAffixExcel<RelicMainAffixExcel>(path);
        RelicSubAffixExcels = LoadRelicAffixExcel<RelicSubAffixExcel>(path);
        ShopExcels = LoadExcel<ShopExcel>(path);
        StageExcels = LoadExcel<StageExcel>(path);
        // low
        AvatarSkillTreeExcels = LoadAvatarInfoExcel<AvatarSkillTreeExcel>(path);
        ChatBubbleExcels = LoadExcel<ChatBubbleExcel>(path);
        EquipmentExcels = LoadExcel<EquipmentExcel>(path);
        PhoneThemeExcels = LoadExcel<PhoneThemeExcel>(path);
        RelicExcels = LoadExcel<RelicExcel>(path);
        ShopGoodsExcels = LoadExcel<ShopGoodsExcel>(path);
        // lowest
    }

    #pragma warning disable CS8601, CS8602

    private static void LoadTextMap(StringPath relativeDirPath)
    {
        var locale = LocaleManager.CurrentLocale;
        TextMap = JsonConvert.DeserializeObject<Dictionary<long, string>>(File.ReadAllText(Path.Combine(relativeDirPath,
            "TextMap", $"TextMap{locale}.json")));

        Log.Information("{0} text entries loaded from text map {1}", TextMap.Count, locale.ToLower());
    }

    private static List<T> LoadExcel<T>(StringPath relativeDirPath) where T : IResource
    {
        var excelAttr = typeof(T).GetCustomAttribute(typeof(ResourceAttribute), true) as ResourceAttribute;
        var excels = new List<T>();
        foreach (var excel in excelAttr.FileNames.Select(fileName => JsonConvert.DeserializeObject<Dictionary<int, T>>(File.ReadAllText(Path.Combine(relativeDirPath,
                     "ExcelOutput", fileName)), new StringEnumConverter()).Values).SelectMany(subExcels => subExcels))
        {
            excel.OnLoad();
            excels.Add(excel);
        }
        Log.Information("{0} {1}s loaded", excels.Count, typeof(T).Name);
        return excels;
    }

    private static Dictionary<int, List<T>> LoadRelicAffixExcel<T>(StringPath relativeDirPath) where T : IResource
    {
        var dict = new Dictionary<int, List<T>>();
        var affixes = LoadExcel<T>(relativeDirPath);
        foreach (dynamic affix in affixes)
        {
            if (dict.ContainsKey(affix.GroupId))
            {
                dict[affix.GroupId].Add(affix);
            }
            else
            {
                dict.Add(affix.GroupId, new List<T>{affix});
            }
        }

        return dict;
    }

    // TODO: normalize avatar promotion excels' loading
    private static List<T> LoadAvatarInfoExcel<T>(StringPath relativeDirPath)
    {
        var excelAttr = typeof(T).GetCustomAttribute(typeof(ResourceAttribute), true) as ResourceAttribute;
        var excels = new List<T>();
        foreach (dynamic excel in excelAttr.FileNames.Select(fileName => JsonConvert.DeserializeObject<Dictionary<int, Dictionary<int, T>>>(File.ReadAllText(Path.Combine(
                     relativeDirPath,
                     "ExcelOutput", fileName)), new StringEnumConverter()).Values.SelectMany(dict => dict.Values)).SelectMany(subExcels => subExcels))
        {
            excel.OnLoad();
            excels.Add(excel);
        }

        Log.Information("{0} {1}s loaded", excels.Count, typeof(T).Name);
        return excels;
    }
}

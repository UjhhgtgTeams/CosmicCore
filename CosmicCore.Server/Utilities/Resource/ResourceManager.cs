using System.Reflection;
using CosmicCore.Server.Utilities.Locale;
using CosmicCore.Server.Utilities.Resource.Resources;
using Newtonsoft.Json;
using Serilog;

namespace CosmicCore.Server.Utilities.Resource;

public static class ResourceManager
{
    public static List<AvatarExcel> AvatarExcels { get; private set; }
    public static List<ItemExcel> ItemExcels { get; private set; }
    public static List<PropExcel> PropExcels { get; private set; }
    public static List<NpcMonsterExcel> NpcMonsterExcels { get; private set; }
    public static List<StageExcel> StageExcels { get; private set; }
    public static List<MazePlaneExcel> MazePlaneExcels { get; private set; }
    public static Dictionary<long, string> TextMap { get; private set; }
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
            Log.Information("Loaded all resources");
        }
        else
        {
            Log.Warning("Resources not found! Please place resources under {0}", dirPath);
        }

        return Directory.Exists(dirPath);
    }

    private static void LoadExcels(StringPath relativeDirPath)
    {
        AvatarExcels = LoadExcel<AvatarExcel>(relativeDirPath);
        ItemExcels = LoadExcel<ItemExcel>(relativeDirPath);
        PropExcels = LoadExcel<PropExcel>(relativeDirPath);
        NpcMonsterExcels = LoadExcel<NpcMonsterExcel>(relativeDirPath);
        StageExcels = LoadExcel<StageExcel>(relativeDirPath);
        MazePlaneExcels = LoadExcel<MazePlaneExcel>(relativeDirPath);
    }

    private static void LoadTextMap(StringPath relativeDirPath)
    {
        var locale = LocaleManager.CurrentLocale;
        TextMap = JsonConvert.DeserializeObject<Dictionary<long, string>>(Path.Combine(relativeDirPath,
            $"/TextMap/TextMap{locale}.json"));
        Log.Information("Loaded {0} text entries from text map {1}", TextMap.Count, locale.ToLower());
    }

    private static List<T> LoadExcel<T>(StringPath relativeDirPath)
    {
        var excelAttr = typeof(T).GetCustomAttribute(typeof(ResourceAttribute), true) as ResourceAttribute;
        var excels = new List<T>();
        foreach (var file in excelAttr.FileNames)
        {
            excels.AddRange(JsonConvert.DeserializeObject<List<T>>(Path.Combine(relativeDirPath,
                "/ExcelOutput/" + excelAttr.FileNames[0] + ".json")) ?? []);
        }
        Log.Information("Loaded {0} {1}s", excels.Count, nameof(T));
        return excels;
    }
}

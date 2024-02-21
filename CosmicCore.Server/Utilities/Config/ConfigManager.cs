using Newtonsoft.Json;
using Serilog;

namespace CosmicCore.Server.Utilities.Config;

public static class ConfigManager
{
    public static Config Config { get; private set; } = new();

    public static void LoadConfig(string path)
    {
        Log.Information("Loading configuration...");
        Log.Warning("Beta versions do not support data persistence so we're creating a new config!");
    }

    public static void SaveConfig(string path)
    {
        var json = JsonConvert.SerializeObject(Config, Formatting.Indented);
        File.WriteAllText(path, json);
    }
}

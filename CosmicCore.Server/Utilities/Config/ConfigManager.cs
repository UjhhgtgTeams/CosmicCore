using CosmicCore.Server.Utilities.Deserialize;
using Newtonsoft.Json;
using Serilog;

namespace CosmicCore.Server.Utilities.Config;

public static class ConfigManager
{
    public static Config Config { get; private set; }

    public static void LoadConfig(StringPath path)
    {
        Log.Information("Loading configuration...");
        if (File.Exists(path))
        {
            Config = SerializeUtils.TryDeserializeFile<Config>(path).Except("Failed to load config!") ?? new Config();
            Log.Information("Configuration loaded from file {0}", path);
        }
        else
        {
            Config = new Config();
            SaveConfig(path);
            Log.Warning("Config file not found; new config file created at {0}", path);
        }
    }

    public static void SaveConfig(StringPath path)
    {
        var json = JsonConvert.SerializeObject(Config, Formatting.Indented);
        File.WriteAllText(path, json);
    }
}

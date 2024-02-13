using System.Reflection;
using System.Text.RegularExpressions;
using Serilog;

namespace CosmicCore.Server.Utilities.Plugin;

public static partial class PluginManager
{
    public static Dictionary<string, IPlugin> Plugins { get; } = []; // plugin name, plugin
    public static bool PluginsLoaded { get; private set; } = false;
    public static bool PluginsEnabled { get; private set; } = false;

    public const int ApiVersion = 1;
    private static DirectoryInfo _pluginsDirectory;

    public static void LoadPlugins()
    {
        if (PluginsLoaded)
        {
            Log.Error("Plugins are already loaded and cannot be loaded twice");
            return;
        }

        try
        {
            _pluginsDirectory = Directory.CreateDirectory("./plugins".ToFullPath());
        }
        catch (Exception ex) when (ex is IOException or UnauthorizedAccessException)
        {
            Log.Error("Failed to create plugin directory!");
            throw; // do not modify stack trace
        }

        PluginsLoaded = true;

        var pluginFiles = _pluginsDirectory.EnumerateFiles("*.dll", SearchOption.TopDirectoryOnly);

        // TODO: dependency check
        // resharper cool; linq hurray
        foreach (var pluginFile in pluginFiles)
        {
            var pluginAssembly = Assembly.LoadFile(pluginFile.FullName);
            foreach (var type in pluginAssembly.GetTypes())
                if (typeof(IPlugin).IsAssignableFrom(type))
                {
                    var plugin = (IPlugin)Activator.CreateInstance(type);

                    // validation
                    if (plugin is null || !IsPluginNameValid(plugin.Name)) continue; // null
                    if (IPlugin.ApiVersion > ApiVersion) // api
                        Log.Warning("API of plugin {0} is newer than server version, plugin may not work correctly!",
                            plugin.Name);

                    plugin.Assembly = pluginAssembly;
                    Plugins.Add(plugin.Name, plugin);
                    try
                    {
                        plugin.OnLoad();
                    }
                    catch (Exception ex)
                    {
                        Log.Warning(ex, "Exception while loading plugin {0}", plugin.Name);
                        Plugins.Remove(plugin.Name);
                    }
                }
        }
    }

    public static void EnablePlugins()
    {
        PluginsEnabled = true;
        foreach (var plugin in Plugins)
            try
            {
                plugin.Value.OnEnable();
            }
            catch (Exception ex)
            {
                Log.Warning(ex, "Exception while enabling plugin {0}", plugin.Key);
            }
    }

    public static void DisablePlugins()
    {
        PluginsEnabled = false;
        foreach (var plugin in Plugins)
        try
        {
            plugin.Value.OnDisable();
        }
        catch (Exception ex)
        {
            Log.Warning(ex, "Exception while disabling plugin {0}", plugin.Key);
        }

        Plugins.Clear();
    }

    public static void ReloadPlugins()
    {
        DisablePlugins();
        EnablePlugins();
    }

    private static bool IsPluginNameValid(string name)
    {
        var regex = ValidPluginNameRegex();
        return regex.IsMatch(name);
    }

    [GeneratedRegex("^[a-z0-9_]+$")]
    private static partial Regex ValidPluginNameRegex();
}

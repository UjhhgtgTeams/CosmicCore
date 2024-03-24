using System.Reflection;
using System.Text.RegularExpressions;
using CosmicCore.Server.Utilities.Command;
using Serilog;

namespace CosmicCore.Server.Utilities.Plugin;

public static partial class PluginManager
{
    private static DirectoryInfo _pluginsDirectory = null!;
    public static Dictionary<string, IPlugin> Plugins { get; } = []; // plugin name, plugin
    public static bool PluginsLoaded { get; private set; } = false;
    public static bool PluginsEnabled { get; private set; } = false;

    public static int ApiVersion => 1;

    public static void LoadPlugins()
    {
        if (PluginsLoaded)
        {
            Log.Error("Plugins are already loaded and cannot be loaded twice");
            return;
        }

        try
        {
            _pluginsDirectory = Directory.CreateDirectory("./plugins");
        }
        catch (Exception ex) when (ex is IOException or UnauthorizedAccessException)
        {
            Log.Error("Failed to create plugin directory!");
            throw; // do not modify stack trace
        }

        PluginsLoaded = true;

        var pluginFiles = _pluginsDirectory.EnumerateFiles("*.dll", SearchOption.TopDirectoryOnly);

        // TODO: dependency check
        foreach (var pluginFile in pluginFiles)
        {
            var pluginAssembly = Assembly.LoadFile(pluginFile.FullName);
            foreach (var type in pluginAssembly.GetTypes())
            {
                if (typeof(IPlugin).IsAssignableFrom(type))
                {
                    var plugin = (IPlugin)Activator.CreateInstance(type)!;
                    var pluginAttr = type.GetCustomAttribute<PluginAttribute>()!;

                    // validation
                    if (plugin is null || !IsPluginNameValid(pluginAttr.Name)) continue; // null
                    if (IPlugin.ApiVersion > ApiVersion) // api
                        Log.Warning("API of plugin {0} is newer than server version, plugin may not work correctly!",
                            pluginAttr.Name);

                    plugin.Assembly = pluginAssembly;
                    Plugins.Add(pluginAttr.Name, plugin);
                    try
                    {
                        Log.Information("Loading plugin {Name}...", pluginAttr.Name);
                        plugin.OnLoad();
                    }
                    catch (Exception ex)
                    {
                        Log.Warning(ex, "Exception while loading plugin {Name}", pluginAttr.Name);
                        Plugins.Remove(pluginAttr.Name);
                    }
                }
            }
        }
    }

    public static void EnablePlugins()
    {
        PluginsEnabled = true;
        foreach (var plugin in Plugins)
        {
            try
            {
                Log.Warning("Enabling plugin {Name}...", plugin.Key);
                plugin.Value.OnEnable();
            }
            catch (Exception ex)
            {
                Log.Warning(ex, "Exception while enabling plugin {Name}", plugin.Key);
            }
        }
    }

    public static void DisablePlugins()
    {
        PluginsEnabled = false;
        foreach (var plugin in Plugins)
        {
            try
            {
                Log.Warning("Disabling plugin {Name}...", plugin.Key);
                plugin.Value.OnDisable();
            }
            catch (Exception ex)
            {
                Log.Warning(ex, "Exception while disabling plugin {Name}", plugin.Key);
            }
        }
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

    /// <summary>
    /// Registers a command. (This method should only and must be used by plugins.)
    /// </summary>
    /// <param name="command">The command to register.</param>
    /// <returns>A boolean indicating whether the command is registered successfully.</returns>
    public static bool RegisterPluginCommand(ICommand command)
    {
        if (!CommandManager.CommandsLoaded)
            return false;

        if (!CommandManager.Commands.Keys.SelectMany().ContainsAnyInRange(command.GetCommandAttribute().Names))
        {
            CommandManager.Commands.Add(command.GetCommandAttribute().Names, command);
            return true;
        }

        return false;
    }

    /// <summary>
    /// Unregisters a command. (This method should only and must be used by plugins.)
    /// </summary>
    /// <param name="command">The command to unregister.</param>
    /// <returns>A boolean indicating whether the command is unregistered successfully.</returns>
    public static bool UnregisterPluginCommand(ICommand command)
    {
        if (!CommandManager.CommandsLoaded)
            return false;

        if (CommandManager.Commands.ContainsValue(command))
        {
            CommandManager.Commands.Remove(command.GetCommandAttribute().Names);
            return true;
        }

        return false;
    }

    [GeneratedRegex("^[a-zA-Z0-9_]+$")]
    private static partial Regex ValidPluginNameRegex();
}

using System.Reflection;
using CosmicCore.Server.Dispatch;
using CosmicCore.Server.Gate;
using CosmicCore.Server.Utilities;
using CosmicCore.Server.Utilities.Command;
using CosmicCore.Server.Utilities.Config;
using CosmicCore.Server.Utilities.Console;
using CosmicCore.Server.Utilities.Handbook;
using CosmicCore.Server.Utilities.Logger;
using CosmicCore.Server.Utilities.Plugin;
using Serilog;

namespace CosmicCore.Server;

public static class Program
{
    public static void Main(string[] arguments)
    {
        // preparation
        Directory.SetCurrentDirectory(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
        LoggerManager.InitLogger();
        Log.Information("Starting {0} {1} for game version {2}...", Const.Name, Const.Version, Const.GameVersion);

        PerformanceWatcher.Start();
        ConfigManager.LoadConfig("./config.json");
        PluginManager.LoadPlugins();
        CommandManager.LoadCommands();
        HandbookGenerator.Generate("./" + Const.Name + " Handbook.txt");
        PluginManager.EnablePlugins();

        // servers
        DispatchServer.Start();
        GateServer.Start();

        // command line
        var timeSpan = PerformanceWatcher.Stop();
        Log.Information("Done (took {Elapsed}s)! Type /help to get started", timeSpan.TotalSeconds);
        ConsoleManager.RunConsoleSession();

        // stop server
        PluginManager.DisablePlugins();
        DispatchServer.Stop();
        GateServer.Stop();
        Log.Information("Goodbye!");
        Log.CloseAndFlush();
    }
}

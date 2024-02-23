using System.Reflection;
using CosmicCore.Server.Dispatch;
using CosmicCore.Server.Gate;
using CosmicCore.Server.Gate.Services.Gacha;
using CosmicCore.Server.Utilities;
using CosmicCore.Server.Utilities.Account;
using CosmicCore.Server.Utilities.Command;
using CosmicCore.Server.Utilities.Config;
using CosmicCore.Server.Utilities.Console;
using CosmicCore.Server.Utilities.Handbook;
using CosmicCore.Server.Utilities.Logger;
using CosmicCore.Server.Utilities.Plugin;
using CosmicCore.Server.Utilities.Resource;
using Serilog;

namespace CosmicCore.Server;

public static class Program
{
    public static readonly AccountDatabase AccountDatabase = new();

    public static void Main(string[] arguments)
    {
        // preparation
        Directory.SetCurrentDirectory(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
        LoggerManager.InitLogger();
        Log.Information("Starting {0} {1} (branch {2}) for game version {3}...", Const.Name, Const.Version,
            Const.GitBranch, Const.GameVersion);

        PerformanceWatcher.Start();
        ConfigManager.LoadConfig("./config.json");
        AccountDatabase.InitializeDatabase("./accounts.db");
        PluginManager.LoadPlugins();
        var generateHandbook = ResourceManager.LoadResources(ConfigManager.Config.ResourceDirPath);
        CommandManager.LoadCommands();
        if (generateHandbook) HandbookGenerator.Generate("./" + Const.Name + " Handbook.txt");
        PluginManager.EnablePlugins();
        GachaService.Initialize("./resources/banners.json");

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
        AccountDatabase.SaveToFile("./accounts.db");
        Log.Information("Goodbye!");
        Log.CloseAndFlush();
    }
}

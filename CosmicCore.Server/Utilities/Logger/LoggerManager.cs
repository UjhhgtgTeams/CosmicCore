using Serilog;
using Serilog.Sinks.SystemConsole.Themes;

namespace CosmicCore.Server.Utilities.Logger;

public static class LoggerManager
{
    public static void InitLogger()
    {
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.Console(theme: AnsiConsoleTheme.Sixteen)
            .WriteTo.File("./" + Const.Name.ToLower() + ".log", rollingInterval: RollingInterval.Day)
            .WriteTo.Debug()
            .CreateLogger();
    }

    private static readonly List<int> QuietCmdIds = [1410, 1433, 46, 73]; // SceneEntityMove, PlayerHeartBeat

    public static bool IsCmdIdLogged(int cmdId)
    {
        return !QuietCmdIds.Contains(cmdId);
    }
}

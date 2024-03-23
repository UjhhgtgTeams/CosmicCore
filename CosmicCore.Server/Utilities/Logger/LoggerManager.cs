using Serilog;
using Serilog.Sinks.Spectre;

namespace CosmicCore.Server.Utilities.Logger;

public static class LoggerManager
{
    private static readonly List<int> QuietCmdIds = [1410, 1433, 46, 73]; // SceneEntityMove, PlayerHeartBeat

    public static void InitLogger()
    {
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            // .WriteTo.Console(theme: AnsiConsoleTheme.Sixteen)
            .WriteTo.Spectre()
            .WriteTo.File("./" + Const.Name.ToLower() + ".log", rollingInterval: RollingInterval.Day)
            .WriteTo.Debug()
            .CreateLogger();
    }

    public static bool IsCmdIdLogged(int cmdId)
    {
        return !QuietCmdIds.Contains(cmdId);
    }
}

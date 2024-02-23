using Serilog;

namespace CosmicCore.Server.Utilities.Logger;

public static class LoggerManager
{
    public static void InitLogger()
    {
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.Console()
            .WriteTo.File("./" + Const.Name.ToLower() + ".log", rollingInterval: RollingInterval.Day)
            .WriteTo.Debug()
            .CreateLogger();
    }
}

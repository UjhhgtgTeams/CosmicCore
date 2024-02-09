using Serilog;
using Serilog.Events;
using Serilog.Sinks.SystemConsole.Themes;

namespace CosmicCore.Server.Utilities.Logger;

public static class LoggerManager
{
    public static void InitLogger()
    {
        const string outputTemplate = "[{Timestamp:HH:mm:ss} {Level:u3}] <{SourceContext}> {Message:lj}{NewLine}{Exception}";
        Log.Logger = new LoggerConfiguration()
            .WriteTo.Console(theme: AnsiConsoleTheme.Code, restrictedToMinimumLevel: LogEventLevel.Debug, outputTemplate: outputTemplate)
            .WriteTo.File("./" + Const.Name.ToLower() + ".log", LogEventLevel.Information,
                rollingInterval: RollingInterval.Day, outputTemplate: outputTemplate)
            .WriteTo.Debug(restrictedToMinimumLevel: LogEventLevel.Debug, outputTemplate: outputTemplate)
            .CreateLogger();
    }
}

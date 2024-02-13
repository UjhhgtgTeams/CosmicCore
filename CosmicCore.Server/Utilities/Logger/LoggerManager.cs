using System.Diagnostics;
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

    public static void AssertNotNull(object? @object)
    {
        if (@object is null)
        {
            var stackFrame = new StackFrame(1).GetMethod();
            Log.Warning("An object in method {0}.{1} is null when it should not be null", stackFrame.Module.Name, stackFrame.Name);
        }
    }
}

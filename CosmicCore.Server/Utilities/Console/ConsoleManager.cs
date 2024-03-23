using CosmicCore.Server.Utilities.Command;
using Serilog;
using Spectre.Console;

namespace CosmicCore.Server.Utilities.Console;

public static class ConsoleManager
{
    public static void RunConsoleSession()
    {
        while (true)
        {
            AnsiConsole.Markup("[gray]>[/] ");
            var input = System.Console.ReadLine() ?? "";
            if (!string.IsNullOrWhiteSpace(input))
            {
                var baseCommand = input.Split(' ')[0];
                if (baseCommand != "stop")
                {
                    CommandManager.ExecuteCommand(input);
                }
                else
                {
                    Log.Warning("Shutting down server...");
                    return;
                }
            }
        }
    }
}

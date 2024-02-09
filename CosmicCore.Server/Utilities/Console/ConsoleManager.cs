using CosmicCore.Server.Utilities.Command;
using Serilog;

namespace CosmicCore.Server.Utilities.Console;

public static class ConsoleManager
{
    public static void RunConsoleSession()
    {
        while (true)
        {
            System.Console.Write("> ");
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

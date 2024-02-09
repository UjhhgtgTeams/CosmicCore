using System.Text;
using Serilog;

namespace CosmicCore.Server.Utilities.Command;

public static class CommandUtils
{
    public static List<string> SplitArgs(string args)
    {
        var arguments = new List<string>();
        if (string.IsNullOrWhiteSpace(args)) return arguments;

        var currentArg = new StringBuilder();
        var isInQuotes = false;

        foreach (var ch in args)
            switch (ch)
            {
                case '"' when isInQuotes:
                    arguments.Add(currentArg.ToString());
                    currentArg = new StringBuilder();
                    isInQuotes = false;
                    break;

                case '"':
                    isInQuotes = true;
                    break;

                case ' ' when isInQuotes:
                    currentArg.Append(ch);
                    break;

                case ' ':
                {
                    if (currentArg.Length > 0)
                    {
                        arguments.Add(currentArg.ToString());
                        currentArg = new StringBuilder();
                    }

                    break;
                }
                default:
                    currentArg.Append(ch);
                    break;
            }

        if (currentArg.Length > 0) arguments.Add(currentArg.ToString());

        return arguments;
    }

    public static void LogReturnCode(ICommand? command, int returnCode)
    {
        Dictionary<int, string?> returnCodeMap;
        returnCodeMap = command != null ? CommandManager.ReturnCodeMap.ConcatenateRange(command.ReturnCodeMap) : CommandManager.ReturnCodeMap;

        if (returnCodeMap.TryGetValue(returnCode, out var message) && message != null)
        {
            if (!message.EndsWith('!'))
                Log.Information(message);
            else
                Log.Error(message);
        }
    }
}

using Serilog;

namespace CosmicCore.Server.Utilities.Command;

public static class CommandUtilities
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

    public static void LogReturnCode(ICommand? command, int returnCode, Account.Account executor)
    {
        var returnCodeMap = command is not null
            ? CommandManager.ReturnCodeMap.ConcatenateRange(command.ReturnCodeMap)
            : CommandManager.ReturnCodeMap;

        if (returnCodeMap.TryGetValue(returnCode, out var message) && message is not null)
        {
            if (!message.EndsWith('!'))
            {
                if (executor != Account.Account.Console)
                {
                    executor.PrivateChat.SyncChat(Account.Account.Console.Id, executor.Id, message);
                }
                else
                {
                    Log.Information(message);
                }
            }
            else
            {
                if (executor != Account.Account.Console)
                {
                    executor.PrivateChat.SyncChat(Account.Account.Console.Id, executor.Id, message);
                }
                else
                {
                    Log.Error(message);
                }
            }
        }
    }

    public static Account.Account? ParseAccountSelector(string selector)
    {
        // TODO: more advanced parser & selector
        if (selector[0] == '@')
        {
            if (long.TryParse(selector.AsSpan(1), out var result))
            {
                return Program.AccountDatabase[result];
            }
        }

        return null;
    }
}

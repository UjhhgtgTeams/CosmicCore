using System.Reflection;
using CosmicCore.Server.Utilities.Plugin;
using Serilog;

namespace CosmicCore.Server.Utilities.Command;

internal static class CommandManager
{
    public static readonly Dictionary<int, string?> ReturnCodeMap = new()
    {
        { 0, null }, // completed successfully
        { -1, "Command does not exist!" }, // not found
        { 1, "Argument invalid!" }, // argument invalid
        { 2, "Permission not enough!" }, // no permission
        { 3, "Command unusable" }, // unusable
        { 999, "Unhandled exception!" } // exception
    };

    public static List<ICommand> Commands { get; } = [];
    public static bool CommandsLoaded;

    public static void LoadCommands()
    {
        if (CommandsLoaded)
        {
            Log.Error("Commands are already loaded and cannot be loaded twice");
            return;
        }

        CommandsLoaded = true;

        Commands.AddRange(
            from type in Assembly.GetExecutingAssembly().GetTypes()
            where typeof(ICommand).IsAssignableFrom(type) && !type.IsAbstract // ignore 'ICommand' itself
            select Activator.CreateInstance(type)
            as ICommand);
        Log.Information("Loaded {0} builtin commands", Commands.Count);

        var commandCnt = 0;
        foreach (var commands in PluginManager.Plugins.Values.Select(plugin => plugin.Commands))
        {
            Commands.AddRange(commands);
            commandCnt += commands.Length;
        }
        Log.Information("Loaded {0} plugin commands", commandCnt);
    }

    public static void ExecuteCommand(string command, Account.Account? executor = null)
    {
        executor ??= Account.Account.ConsoleAccount;

        var args = CommandUtils.SplitArgs(command).ToList();
        args.RemoveAt(0);
        var exeFlag = false;
        foreach (var cmd in Commands)
        {
            if (cmd.Names.Contains(command))
            {
                var result = cmd.OnExecute(string.Join(' ', args), executor);
                CommandUtils.LogReturnCode(cmd, result);

                exeFlag = true;
                return;
            }
        }

        if (!exeFlag)
            CommandUtils.LogReturnCode(null, -1);
    }
}

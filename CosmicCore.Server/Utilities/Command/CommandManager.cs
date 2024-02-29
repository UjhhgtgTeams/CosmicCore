using System.Reflection;
using CosmicCore.Server.Utilities.Plugin;
using Serilog;

namespace CosmicCore.Server.Utilities.Command;

public static class CommandManager
{
    public static readonly Dictionary<int, string?> ReturnCodeMap = new()
    {
        { 0, null }, // completed successfully
        { -1, "Command does not exist!" }, // not found
        { 1, "Argument invalid!" }, // argument invalid
        { 2, "Permission not enough!" }, // no permission
        { 3, "Command unusable" }, // unusable
        { 999, "Unhandled exception occured while executing command!" } // exception
    };

    public static List<ICommand> Commands { get; } = [];
    public static bool CommandsLoaded { get; private set; }

    public static void LoadCommands()
    {
        if (CommandsLoaded)
        {
            Log.Error("Commands are already loaded and cannot be loaded twice");
            return;
        }

        Log.Information("Loading commands...");
        CommandsLoaded = true;

        Commands.AddRange(Assembly.GetExecutingAssembly()
            .GetTypes()
            .Where(type => typeof(ICommand).IsAssignableFrom(type) && !type.IsAbstract)
            .Select(Activator.CreateInstance)
            .Cast<ICommand>());
        Log.Information("{Count} builtin commands loaded", Commands.Count);

        var commandCnt = 0;
        foreach (var commands in PluginManager.Plugins.Values.Select(plugin => plugin.Commands))
        {
            Commands.AddRange(commands);
            commandCnt += commands.Length;
        }

        Log.Information("{0} plugin commands loaded", commandCnt);
    }

    public static void ExecuteCommand(string command, Account.Account? executor = null)
    {
        executor ??= Account.Account.Console;
        if (string.IsNullOrWhiteSpace(command)) return;

        var args = CommandUtilities.SplitArgs(command).ToList();
        args.RemoveAt(0);

        foreach (var cmd in Commands)
        {
            var attr = GetCommandAttributeOf(cmd);
            if (attr.Names.Contains(command))
            {
                if (executor.HasPermissions(attr.RequiredPermissions))
                {
                    try
                    {
                        var result = cmd.OnExecute(string.Join(' ', args), executor);
                        CommandUtilities.LogReturnCode(cmd, result, executor);
                    }
                    catch (Exception)
                    {
                        CommandUtilities.LogReturnCode(null, 999, executor);
                    }

                    return;
                }
                else
                {
                    CommandUtilities.LogReturnCode(null, 2, executor);
                    return;
                }
            }
        }

        CommandUtilities.LogReturnCode(null, -1, executor);
    }

    public static CommandAttribute GetCommandAttributeOf<T>() where T : ICommand
    {
        return GetCommandAttributeOf(typeof(T));
    }

    public static CommandAttribute GetCommandAttributeOf(Type type)
    {
        return type.GetCustomAttribute(typeof(CommandAttribute), true) as CommandAttribute ?? new CommandAttribute();
    }

    public static CommandAttribute GetCommandAttributeOf(ICommand command)
    {
        return GetCommandAttributeOf(command.GetType());
    }
}

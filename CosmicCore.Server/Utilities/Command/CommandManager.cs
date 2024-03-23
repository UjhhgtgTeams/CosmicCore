using System.Reflection;
using Serilog;

namespace CosmicCore.Server.Utilities.Command;

public static class CommandManager
{
    public static readonly Dictionary<int, string?> ReturnCodeMap = new()
    {
        { 0, null }, // completed successfully
        { -1, "Command does not exist!" }, // not found
        { 1, "Argument invalid!" }, // argument invalid
        { 2, "Permission not enough!" } // no permission
    };

    public static Dictionary<IEnumerable<string>, ICommand> Commands { get; } = [];
    public static bool CommandsLoaded { get; private set; }

    public static void LoadBuiltinCommands()
    {
        if (CommandsLoaded)
        {
            Log.Error("Commands are already loaded and cannot be loaded twice");
            return;
        }

        Log.Information("Loading commands...");
        CommandsLoaded = true;

        foreach (var command in Assembly.GetExecutingAssembly()
                     .GetTypes()
                     .Where(type => typeof(ICommand).IsAssignableFrom(type) && !type.IsAbstract)
                     .Select(Activator.CreateInstance)
                     .Cast<ICommand>())
        {
            Commands.Add(command.GetCommandAttribute().Names, command);
        }

        Log.Information("{0} builtin commands loaded", Commands.Count);
    }

    public static void ExecuteCommand(string command)
    {
        if (string.IsNullOrWhiteSpace(command)) return;

        foreach (var cmd in Commands)
        {
            if (cmd.Key.Contains(command))
            {
                var result = -1;

                try
                {
                    result = cmd.Value.OnExecute(command);
                }
                catch (Exception ex)
                {
                    Log.Error(ex, "Unhandled exception occured while executing command!");
                }

                break;
            }
        }
    }

    public static CommandAttribute GetCommandAttribute(this Type type)
    {
        return type.GetCustomAttribute<CommandAttribute>()!;
    }

    public static CommandAttribute GetCommandAttribute(this ICommand command)
    {
        return command.GetType().GetCommandAttribute();
    }
}

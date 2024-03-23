using System.Text;
using CosmicCore.Server.Gate.Manager.Handlers;
using CosmicCore.Server.Utilities.Command;
using CosmicCore.Server.Utilities.Plugin;
using Serilog;

namespace CosmicCore.Server.LuaPlugin;

[Plugin(Name = "LuaPlugin", Description = "Executes custom Lua scripts on client.")]
public class Plugin : IPlugin
{
    private readonly LuaCommand _command = new();

    public override void OnLoad()
    {
    }

    public override void OnEnable()
    {
        PluginManager.RegisterPluginCommand(_command);
    }

    public override void OnDisable()
    {
        PluginManager.UnregisterPluginCommand(_command);
    }
}

[Command(Names = ["lua", "luascript"], Description = "Manages the Lua script to execute on client.",
    Usage = "get|show|set <path>", RequiredPermissions = ["admin.lua"])]
public class LuaCommand : ICommand
{
    private string? LuaScriptPath { get; set; }

    public Dictionary<int, string> ReturnCodeMap { get; } = new()
    {
        { 4, "No Lua script is set!" },
        { 5, "Given file does not exist!" },
        { 6, "Given file is not a Lua script or Lua bytecode!" },
        { 7, "Executing Lua script manually does not work!" }
    };

    public int OnExecute(string args)
    {
        var arguments = args.Split(' ');

        switch (arguments[0])
        {
            case "set":
                if (arguments.Length < 2)
                    return 1;
                if (!File.Exists(arguments[1]))
                    return 5;

                LuaScriptPath = arguments[1];
                if (IsTextFile(arguments[1]))
                {
                    LuaScriptCompiler.Instance.EnsureExists();
                    PlayerReqGroup.RemoteExecutedLua = LuaScriptCompiler.Instance.Run(arguments[1]);
                }
                else
                {
                    PlayerReqGroup.RemoteExecutedLua = File.ReadAllBytes(arguments[1]);
                }

                return 0;

            case "show":
                if (LuaScriptPath is null)
                    return 4;

                Log.Information("Current Lua script path: {Path}", LuaScriptPath);
                break;

            case "run":
                return 7;
        }

        return 1;
    }

    private static bool IsTextFile(string path)
    {
        if (!File.Exists(path) || Directory.Exists(path))
        {
            return false;
        }

        // TODO: code by chatgpt
        try
        {
            using var reader = new StreamReader(path, Encoding.UTF8, true);

            int charValue;
            while ((charValue = reader.Read()) != -1)
            {
                // Check for non-printable ASCII characters (0-31, 127) excluding tab, newline, and carriage return
                if (charValue is >= 0 and <= 8 or >= 11 and <= 31 or 127)
                {
                    return false;
                }
            }

            return true;
        }
        catch
        {
            return false;
        }
    }
}

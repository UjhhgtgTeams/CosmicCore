using CosmicCore.Server.Utilities.Command;
using CosmicCore.Server.Utilities.Plugin;
using Serilog;

namespace CosmicCore.Server.ExamplePlugin;

public class Plugin : IPlugin
{
    public override string Name => "ExamplePlugin";
    public override string Description => "An example plugin.";
    public override string[] Dependencies => [];
    public override ICommand[] Commands => [];

    public override void OnLoad()
    {
        Log.Information("Example plugin loading");
    }

    public override void OnEnable()
    {
        Log.Information("Example plugin enabling");
    }

    public override void OnDisable()
    {
        Log.Information("Example plugin disabling");
    }
}

using CosmicCore.Server.Utilities.Command;
using CosmicCore.Server.Utilities.Plugin;
using Serilog;

namespace CosmicCore.Server.ExamplePlugin;

[Plugin(Name = "ExamplePlugin", Description = "An example plugin which does nothing.")]
public class Plugin : IPlugin
{
    public override void OnLoad()
    {
        Log.Information("Example plugin loading...");
    }

    public override void OnEnable()
    {
        Log.Information("Example plugin enabling...");
    }

    public override void OnDisable()
    {
        Log.Information("Example plugin disabling...");
    }
}

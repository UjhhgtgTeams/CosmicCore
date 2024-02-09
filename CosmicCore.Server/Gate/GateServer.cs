using CosmicCore.Server.Gate.Network;
using CosmicCore.Server.Utilities.Config;
using CosmicCore.Server.Utilities;
using Serilog;

namespace CosmicCore.Server.Gate;

internal static class GateServer
{
    public static void Start()
    {
        Log.Warning("Starting gate server...");
        GateService.Start(ConfigManager.Config.GateServer);
        Log.Information("Gate server started");
    }

    public static void Stop()
    {
        Log.Warning("Stopping gate server...");
        GateService.Stop();
        Log.Information("Gate server stopped");
    }
}

using CosmicCore.Server.Gate.Network;
using CosmicCore.Server.Utilities.Config;
using Serilog;

namespace CosmicCore.Server.Gate;

public static class GateServer
{
    public static void Start()
    {
        Log.Warning("Starting gate server...");
        GateService.Start(ConfigManager.Config.GateServer);
        Log.Information("Gate server started and listening on {Address}", ConfigManager.Config.GateServer.DisplayAddress);
    }

    public static void Stop()
    {
        Log.Warning("Stopping gate server...");
        GateService.Stop();
        Log.Information("Gate server stopped");
    }
}

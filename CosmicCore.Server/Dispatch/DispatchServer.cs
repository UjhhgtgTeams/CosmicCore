using CosmicCore.Server.Dispatch.Service;
using CosmicCore.Server.Dispatch.Service.Manager;
using CosmicCore.Server.Utilities.Config;
using Serilog;

namespace CosmicCore.Server.Dispatch;

internal static class DispatchServer
{
    public static void Start()
    {
        Log.Warning("Starting dispatch server...");
        RegionManager.Initialize(ConfigManager.Config.DispatchServer.Region);
        DispatchService.Start(ConfigManager.Config.DispatchServer);
        Log.Information("Dispatch server started");
    }

    public static void Stop()
    {
        Log.Warning("Stopping dispatch server...");
        DispatchService.Stop();
        Log.Information("Dispatch server stopped");
    }
}

using CosmicCore.Protos;

namespace CosmicCore.Server.Dispatch.Service.Manager;

public static class RegionManager
{
    private static Utilities.Config.RegionConfig _config;

    public static void Initialize(Utilities.Config.RegionConfig config)
    {
        _config = config;
    }

    public static RegionInfo RegionEntry => _config.ToProto();

    public static string TopServerRegionName => _config.Name;
}

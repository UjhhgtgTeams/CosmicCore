using Ceen;
using CosmicCore.Protos;
using CosmicCore.Server.Dispatch.Service.Manager;
using CosmicCore.Server.Dispatch.Utils;
using CosmicCore.Server.Utilities;
using Log = Serilog.Log;

namespace CosmicCore.Server.Dispatch.Handlers;

public class QueryDispatchHandler : IHttpModule
{
    public async Task<bool> HandleAsync(IHttpContext context)
    {
        var query = context.Request.QueryString;
        var version = query["version"];
        var timestamp = query["t"];
        var languageType = query["language_type"];
        var platformType = query["platform_type"];

        Log.Debug("Received dispatch query from version {Version}, time {Timestamp}, language {LanguageType} and platform {PlatformType}", version, timestamp, languageType, platformType);

        context.Response.StatusCode = HttpStatusCode.OK;
        context.Response.ContentType = "text/plain";
        await context.Response.WriteAllAsync(Convert.ToBase64String(ProtobufUtil.Serialize(new DispatchRegionData
        {
            Retcode = (uint)Retcode.Success,
            TopSeverRegionName = RegionManager.TopServerRegionName,
            RegionList = { RegionManager.RegionEntry }
        })));

        return true;
    }
}

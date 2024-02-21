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

        Log.Debug("Received dispatch query from version {0}, time {1}, language {2} and platform {3}", version, timestamp, languageType, platformType);

        context.Response.StatusCode = HttpStatusCode.OK;
        context.Response.ContentType = "text/plain";
        await context.Response.WriteAllAsync(Convert.ToBase64String(ProtobufUtilities.Serialize(new RegionList
        {
            Retcode = (uint)Retcode.Success,
            TopServerRegionName = RegionManager.TopServerRegionName,
            RegionInfoList = { RegionManager.RegionEntry }
        })));

        return true;
    }
}

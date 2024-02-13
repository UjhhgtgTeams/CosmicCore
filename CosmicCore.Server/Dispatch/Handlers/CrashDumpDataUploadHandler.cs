using Ceen;
using CosmicCore.Server.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Log = Serilog.Log;

namespace CosmicCore.Server.Dispatch.Handlers;

public class CrashDumpDataUploadHandler : IHttpModule
{
    public async Task<bool> HandleAsync(IHttpContext context)
    {
        var logs = context.Request.Body.ReadAllAsString();
        Log.Debug("Received crash dump upload from client: {Logs}", logs);

        context.Response.StatusCode = HttpStatusCode.OK;
        context.Response.ContentType = "application/json";
        await context.Response.WriteAllJsonAsync(JsonConvert.SerializeObject(new JObject
        {
            { "code", 0 }
        }));

        return true;
    }
}

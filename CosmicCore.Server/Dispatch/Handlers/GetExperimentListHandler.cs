using Ceen;
using CosmicCore.Server.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CosmicCore.Server.Dispatch.Handlers;

public class GetExperimentListHandler : IHttpModule
{
    public async Task<bool> HandleAsync(IHttpContext context)
    {
        context.Response.StatusCode = HttpStatusCode.OK;
        context.Response.ContentType = "application/json";

        await context.Response.WriteAllJsonAsync(JsonConvert.SerializeObject(new JObject
        {
            { "retcode", (int)Retcode.Success },
            { "message", "" },
            { "success", true }
        }));

        return true;
    }
}

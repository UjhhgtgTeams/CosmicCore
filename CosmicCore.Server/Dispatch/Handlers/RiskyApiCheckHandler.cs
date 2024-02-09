using Ceen;
using CosmicCore.Server.Dispatch.Utils;
using CosmicCore.Server.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CosmicCore.Server.Dispatch.Handlers;

internal class RiskyApiCheckHandler : IHttpModule
{
    public async Task<bool> HandleAsync(IHttpContext context)
    {
        context.Response.StatusCode = HttpStatusCode.OK;
        context.Response.ContentType = "application/json";
        await context.Response.WriteAllJsonAsync(JsonConvert.SerializeObject(new JObject
        {
            {"retcode", 0},
            {"message", "OK"},
            {"data", new JObject
            {
                {"id", ""},
                {"action", "ACTION_NONE"},
                {"geetest", null}
            }}
        }));

        return true;
    }
}

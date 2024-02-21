using Ceen;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CosmicCore.Server.Dispatch.Handlers;

public class RiskyApiCheckHandler : IHttpModule
{
    public async Task<bool> HandleAsync(IHttpContext context)
    {
        context.Response.StatusCode = HttpStatusCode.OK;
        context.Response.ContentType = "application/json";
        await context.Response.WriteAllJsonAsync(JsonConvert.SerializeObject(new JObject
        {
            { "retcode", 0 },
            { "message", "OK" },
            {
                "data", new JObject
                {
                    { "id", "" },
                    { "action", "ACTION_NONE" },
                    { "geetest", null }
                }
            }
        }));

        return true;
    }
}

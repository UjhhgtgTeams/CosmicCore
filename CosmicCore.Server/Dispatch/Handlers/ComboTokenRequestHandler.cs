using Ceen;
using CosmicCore.Server.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CosmicCore.Server.Dispatch.Handlers;

public class ComboTokenRequestHandler : IHttpModule
{
    public async Task<bool> HandleAsync(IHttpContext context)
    {
        var rawData = await context.Request.Body.ReadAllAsStringAsync();
        var request =
            JsonConvert.DeserializeObject<JObject>((string)JsonConvert.DeserializeObject<JObject>(rawData)["data"]);

        var response = new JObject
        {
            { "retcode", (int)Retcode.Success },
            { "message", "OK" },
            {
                "data", new JObject
                {
                    { "combo_id", 1 },
                    { "open_id", request["uid"] },
                    { "combo_token", request["token"] },
                    { "data", new JObject { { "guest", false } } },
                    { "heartbeat", false },
                    { "account_type", 1 },
                    { "fatigue_remind", null }
                }
            }
        };

        context.Response.StatusCode = HttpStatusCode.OK;
        context.Response.ContentType = "application/json";

        await context.Response.WriteAllJsonAsync(JsonConvert.SerializeObject(response));

        return true;
    }
}

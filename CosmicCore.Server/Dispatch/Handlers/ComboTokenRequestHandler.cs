using Ceen;
using CosmicCore.Server.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Log = Serilog.Log;

namespace CosmicCore.Server.Dispatch.Handlers;

public class ComboTokenRequestHandler : IHttpModule
{
    public async Task<bool> HandleAsync(IHttpContext context)
    {
        var rawData = await context.Request.Body.ReadAllAsStringAsync();
        Log.Debug("raw: {0}", rawData);
        var notSoRaw = JsonConvert.DeserializeObject<JObject>(rawData);
        Log.Debug("notsoraw: {0}", notSoRaw);
        var request = JsonConvert.DeserializeObject<JObject>((string)notSoRaw["data"]);
        Log.Debug("request: {0}", request);

        var response = new JObject
        {
            { "retcode", (int)Retcode.Success },
            { "message", "OK" },
            { "data", new JObject
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

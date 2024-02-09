using Ceen;
using CosmicCore.Server.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CosmicCore.Server.Dispatch.Handlers;

internal class FingerprintGetHandler : IHttpModule
{
    public async Task<bool> HandleAsync(IHttpContext context)
    {
        var request = JsonConvert.DeserializeObject<JObject>(context.Request.Body.ReadAllAsString());
        context.Response.StatusCode = HttpStatusCode.OK;
        context.Response.ContentType = "application/json";

        var response = new JObject
        {
            {"retcode", (int)Retcode.Success},
            {"message", "OK"},
            {"data", new JObject
            {
                {"code", 0},
                {"message", ""},
                {"device_fp", (string)request["device_fp"]}
            }}
        };

        await context.Response.WriteAllJsonAsync(JsonConvert.SerializeObject(response));

        return true;
    }
}

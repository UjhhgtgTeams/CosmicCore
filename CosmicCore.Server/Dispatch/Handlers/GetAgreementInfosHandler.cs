using Ceen;
using CosmicCore.Server.Dispatch.Utils;
using CosmicCore.Server.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CosmicCore.Server.Dispatch.Handlers;

internal class GetAgreementInfosHandler : IHttpModule
{
    public async Task<bool> HandleAsync(IHttpContext context)
    {
        context.Response.StatusCode = HttpStatusCode.OK;
        context.Response.ContentType = "application/json";
        await context.Response.WriteAllJsonAsync(JsonConvert.SerializeObject(new JObject
        {
            {"retcode", (int)Retcode.Success},
            {"message", "OK"},
            {"data", new JObject
            {
                { "marketing_agreements", new JArray() }
            }}
        }));

        return true;
    }
}

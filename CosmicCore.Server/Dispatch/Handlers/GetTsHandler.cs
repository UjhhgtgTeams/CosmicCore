using Ceen;
using CosmicCore.Server.Utilities;
using Newtonsoft.Json;

namespace CosmicCore.Server.Dispatch.Handlers;

internal class GetTsHandler : IHttpModule
{
    public async Task<bool> HandleAsync(IHttpContext context)
    {
        context.Response.StatusCode = HttpStatusCode.OK;
        context.Response.ContentType = "application/json";
        await context.Response.WriteAllJsonAsync(JsonConvert.SerializeObject(new
        {
            retcode = (int)Retcode.Success,
            message = "OK",
            data =
            new
            {
                code = 0,
                message = "app running",
                milliTs = DateTimeOffset.Now.ToUnixTimeMilliseconds()
            }
        }));

        return true;
    }
}

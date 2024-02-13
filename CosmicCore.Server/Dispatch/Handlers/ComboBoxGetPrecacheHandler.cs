using Ceen;

namespace CosmicCore.Server.Dispatch.Handlers;

public class ComboBoxGetPrecacheHandler : IHttpModule
{
    public async Task<bool> HandleAsync(IHttpContext context)
    {
        context.Response.StatusCode = HttpStatusCode.OK;
        context.Response.ContentType = "application/json";

        await context.Response.WriteAllJsonAsync(
            """{"retcode":0,"message":"OK","data":{"vals":{"url":"","enable":"false"}}}""");

        return true;
    }
}

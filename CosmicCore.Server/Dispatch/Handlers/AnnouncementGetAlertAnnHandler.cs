using Ceen;
using Newtonsoft.Json;

namespace CosmicCore.Server.Dispatch.Handlers;

public class AnnouncementGetAlertAnnHandler : IHttpModule
{
    public async Task<bool> HandleAsync(IHttpContext context)
    {
        context.Response.StatusCode = HttpStatusCode.OK;
        context.Response.ContentType = "application/json";
        await context.Response.WriteAllJsonAsync(JsonConvert.SerializeObject(new
        {
            retcode = 0,
            message = "OK",
            data =
            new
            {
                alert = false,
                alert_id = 0,
                remind = true,
                extra_remind = false
            }
        }));

        return true;
    }
}

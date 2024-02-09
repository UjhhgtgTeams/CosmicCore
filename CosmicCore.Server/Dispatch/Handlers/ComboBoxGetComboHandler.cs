using Ceen;

namespace CosmicCore.Server.Dispatch.Handlers;

internal class ComboBoxGetComboHandler : IHttpModule
{
    public async Task<bool> HandleAsync(IHttpContext context)
    {
        context.Response.StatusCode = HttpStatusCode.OK;
        context.Response.ContentType = "application/json";

        await context.Response.WriteAllJsonAsync(
            """{"retcode":0,"message":"OK","data":{"vals":{"kibana_pc_config":"{\"enable\":0,\"level\":\"Info\",\"modules\":[\"download\"]}","network_report_config":"{\"enable\":0,\"status_codes\":[206],\"url_paths\":[\"dataUpload\",\"red_dot\"]}","list_price_tierv2_enable":"false","pay_payco_centered_host":"bill.payco.com","telemetry_config":"{\"dataupload_enable\":0,}","enable_web_dpi":"true"}}}""");

        return true;
    }
}

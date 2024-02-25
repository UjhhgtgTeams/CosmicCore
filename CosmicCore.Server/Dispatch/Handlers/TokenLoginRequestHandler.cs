using Ceen;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CosmicCore.Server.Dispatch.Handlers;

public class TokenLoginRequestHandler : IHttpModule
{
    public async Task<bool> HandleAsync(IHttpContext context)
    {
        context.Response.StatusCode = HttpStatusCode.OK;
        context.Response.ContentType = "application/json";

        var response = new JObject
        {
            { "retcode", 0 },
            { "message", "OK" },
            {
                "data", new JObject
                {
                    {
                        "account", new JObject
                        {
                            { "uid", 1337 },
                            { "name", "ujhhgtg" },
                            { "email", "ujhhgtg@cosmiccore.com" },
                            { "mobile", "" },
                            { "is_email_verify", "0" },
                            { "realname", "" },
                            { "identity_card", "" },
                            { "safe_mobile", "" },
                            { "facebook_name", "" },
                            { "google_name", "" },
                            { "twitter_name", "" },
                            { "game_center_name", "" },
                            { "apple_name", "" },
                            { "sony_name", "" },
                            { "tap_name", "" },
                            { "country", "CN" },
                            { "reactivate_ticket", "" },
                            { "area_code", "**" },
                            { "device_grant_ticket", "" },
                            { "steam_name", "" },
                            { "unmasked_email", "" },
                            { "unmasked_email_type", 0 },
                            { "token", "verysecuretoken" }
                        }
                    },
                    { "device_grant_required", false },
                    { "safe_moblie_required", false },
                    { "realperson_required", false },
                    { "reactivate_required", false },
                    { "realname_operation", "None" }
                }
            }
        };

        await context.Response.WriteAllJsonAsync(JsonConvert.SerializeObject(response));
        return true;
    }
}

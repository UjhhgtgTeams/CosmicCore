using Ceen;
using CosmicCore.Server.Dispatch.Utils;
using CosmicCore.Server.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CosmicCore.Server.Dispatch.Handlers;

internal class TokenLoginRequestHandler : IHttpModule
{
    public async Task<bool> HandleAsync(IHttpContext context)
    {
        var response = new JObject
        {
            { "retcode", (int)Retcode.Success },
            { "message", "OK" },
            {
                "data", new JObject
                {
                    {
                        "account", new JObject
                        {
                            { "uid", "" },
                            { "name", "" },
                            { "email", "" },
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
                            { "token", "" }
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

        var request = JsonConvert.DeserializeObject<JObject?>(context.Request.Body.ReadAllAsString());

        if (request == null)
        {
            response["retcode"] = (int)Retcode.LoginError;
            response["message"] = "Error logging in";
            await context.Response.WriteAllJsonAsync(JsonConvert.SerializeObject(response));
            return true;
        }

        var requestId = Convert.ToInt64((string)request["uid"]);

        if (!Program.AccountDatabase.ContainsAccount(requestId) ||
            Program.AccountDatabase[requestId].DispatchToken != (string)request["token"])
        {
            response["retcode"] = (int)Retcode.LoginUserNotFound;
            response["message"] = "Game account cache information error";
            await context.Response.WriteAllJsonAsync(JsonConvert.SerializeObject(response));
            return true;
        }

        var account = Program.AccountDatabase[requestId];
        response["data"]["account"]["uid"] = account.Id.ToString();
        response["data"]["account"]["name"] = account.UserName;
        response["data"]["account"]["email"] = account.EmailAddress;
        response["data"]["account"]["token"] = account.DispatchToken;
        await context.Response.WriteAllJsonAsync(JsonConvert.SerializeObject(response));
        return true;
    }
}

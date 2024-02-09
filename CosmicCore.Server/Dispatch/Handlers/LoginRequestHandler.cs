using Ceen;
using CosmicCore.Server.Dispatch.Utils;
using CosmicCore.Server.Utilities;
using CosmicCore.Server.Utilities.Account;
using CosmicCore.Server.Utilities.Config;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CosmicCore.Server.Dispatch.Handlers;

internal class LoginRequestHandler : IHttpModule
{
    public async Task<bool> HandleAsync(IHttpContext context)
    {
        var request = JsonConvert.DeserializeObject<JObject>(context.Request.Body.ReadAllAsString());
        context.Response.StatusCode = HttpStatusCode.OK;
        context.Response.ContentType = "application/json";

        var response = new JObject
        {
            { "retcode", (int)Retcode.Success },
            { "message", "OK" },
            {
                "data", new JObject
                {
                    { "account", new JObject
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
                    }},
                    { "device_grant_required", false },
                    { "safe_moblie_required", false },
                    { "realperson_required", false },
                    { "reactivate_required", false },
                    { "realname_operation", "None" }
                }
            }
        };

        var loginData = ((string)request["account"]).Split('|');
        if (loginData.Length != 2)
        {
            response["retcode"] = (int)Retcode.LoginError;
            response["message"] = "Error logging in";
        }
        else
        {
            var username = loginData[0];
            var password = loginData[1];
            if (!Program.AccountDatabase.ContainsAccount(username))
            {
                if (ConfigManager.Config.ServerOptions.AutoCreateAccount)
                {
                    Program.AccountDatabase.AddAccount(new Account(Program.AccountDatabase.NextId, username, password));
                }
                else
                {
                    response["retcode"] = (int)Retcode.LoginUserNotFound;
                    response["message"] = "Username not found.";
                }
            }
            else
            {
                var account = Program.AccountDatabase[username];
                response["data"]["account"]["uid"] = account.Id.ToString();
                response["data"]["account"]["name"] = account.UserName;
                response["data"]["account"]["email"] = account.EmailAddress;
            }
        }

        await context.Response.WriteAllJsonAsync(JsonConvert.SerializeObject(response));
        return true;
    }
}

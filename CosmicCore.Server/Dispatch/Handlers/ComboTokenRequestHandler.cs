using Ceen;
using CosmicCore.Server.Dispatch.Utils;
using CosmicCore.Server.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CosmicCore.Server.Dispatch.Handlers;

internal class ComboTokenRequestHandler : IHttpModule
{
    public async Task<bool> HandleAsync(IHttpContext context)
    {
        var request = JsonConvert.DeserializeObject<JObject>(context.Request.Body.ReadAllAsString())["data"];
        context.Response.StatusCode = HttpStatusCode.OK;
        context.Response.ContentType = "application/json";

        var response = new JObject
        {
            {"retcode", (int)Retcode.Success},
            {"message", "OK"},
            {"data", new JObject
                {
                { "account_type", 1 },
                { "heartbeat", false },
                { "combo_id", 1 },
                { "combo_token", "" },
                { "open_id", "" },
                { "data", new JObject { { "guest", false } } },
                { "fatigue_remind", null }
                }
            }
        };

        var requestId = Convert.ToInt64((string)request["uid"]);
        if (!Program.AccountDatabase.ContainsAccount(requestId))
        {
            response["retcode"] = (int)Retcode.LoginUserNotFound;
            response["message"] = "Username not found.";
        }
        else if (Program.AccountDatabase[requestId].DispatchToken != (string)request["data"]["token"])
        {
            response["retcode"] = (int)Retcode.LoginUserNotFound;
            response["message"] = "Game account cache information error";
        }
        else
        {
            var account = Program.AccountDatabase[requestId];
            response["data"]["open_id"] = account.Id.ToString();
            response["data"]["combo_token"] = account.ComboToken;
        }

        await context.Response.WriteAllJsonAsync(JsonConvert.SerializeObject(response));
        return true;
    }
}

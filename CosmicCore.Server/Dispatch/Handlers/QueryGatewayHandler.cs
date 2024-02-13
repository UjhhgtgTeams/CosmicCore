using Ceen;
using CosmicCore.Protos;
using CosmicCore.Server.Dispatch.Utils;
using CosmicCore.Server.Utilities.Config;

namespace CosmicCore.Server.Dispatch.Handlers;

public class QueryGatewayHandler : IHttpModule
{
    public async Task<bool> HandleAsync(IHttpContext context)
    {
        context.Response.StatusCode = HttpStatusCode.OK;
        context.Response.ContentType = "text/plain";
        var data = ConfigManager.Config.DownloadData;

        var gateserver = new Gateserver
        {
            Msg = "OK",
            Ip = ConfigManager.Config.GateServer.Address,
            RegionName = Const.Name,
            Port = (uint)ConfigManager.Config.GateServer.Port,
            Unk1 = true,
            Unk2 = true,
            Unk3 = true,
            Unk4 = true,
            Unk5 = true,
            Unk6 = true
        };

        if (data.AssetBundleUrl is not null) gateserver.AssetBundleUrl = data.AssetBundleUrl;
        if (data.ExResourceUrl is not null) gateserver.ExResourceUrl = data.ExResourceUrl;
        if (data.LuaUrl is not null)
        {
            gateserver.LuaUrl = data.LuaUrl;
            gateserver.MdkResVersion = data.LuaUrl.Split('/')[^1].Split("_")[1];
        }
        if (data.IFixUrl is not null)
        {
            gateserver.IfixUrl = data.IFixUrl;
            gateserver.IfixVersion = data.IFixUrl.Split('/')[^1].Split("_")[1];
        }

        await context.Response.WriteAllAsync(Convert.ToBase64String(ProtobufUtil.Serialize(gateserver)));
        return true;
    }
}

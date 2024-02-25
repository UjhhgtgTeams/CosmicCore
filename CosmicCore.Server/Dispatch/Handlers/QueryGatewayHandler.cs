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

        var gateserver = new Gateserver
        {
            Retcode = 0,
            Msg0 = "OK",
            // Ip = ConfigManager.Config.GateServer.Address,
            Ip = "127.0.0.1",
            RegionName = Const.Name,
            Port = (uint)ConfigManager.Config.GateServer.Port,
            Unk1 = true,
            Unk2 = true,
            Unk3 = true,
            Unk4 = true,
            Unk5 = true,
            Unk6 = true,
            UseTcp = true,
            AssetBundleUrl = "https://autopatchos.starrails.com/asb/BetaLive/output_6510636_cb4da670a18a",
            ExResourceUrl = "https://autopatchos.starrails.com/design_data/BetaLive/output_6519585_2be8ac313835",
            IfixVersion = "https://autopatchos.starrails.com/ifix/BetaLive/output_6523427_28cc5c21c689",
            LuaUrl = "https://autopatchos.starrails.com/lua/BetaLive/output_6516960_dede96733b5b"
        };

        await context.Response.WriteAllAsync(Convert.ToBase64String(ProtobufUtilities.Serialize(gateserver)));
        return true;
    }
}

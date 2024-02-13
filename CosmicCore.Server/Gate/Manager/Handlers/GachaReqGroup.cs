using CosmicCore.Protos;
using CosmicCore.Server.Gate.Manager.Handlers.Core;
using CosmicCore.Server.Gate.Network;
using CosmicCore.Server.Gate.Services.Gacha;

namespace CosmicCore.Server.Gate.Manager.Handlers;

public class GachaReqGroup
{
    [PacketHandler(CmdId.CmdDoGachaCsReq)]
    public static void OnDoGachaCsReq(NetSession session, int cmdId, object data)
    {
        if (session.State == NetSessionState.Active)
        {
            var request = data as DoGachaCsReq;
            GachaService.PerformPull(session.Owner, (int)request.GachaId, (int)request.GachaNum);
        }
    }

    [PacketHandler(CmdId.CmdExchangeGachaCeilingCsReq)]
    public static void OnExchangeGachaCeilingCsReq(NetSession session, int cmdId, object data)
    {
        var request = data as ExchangeGachaCeilingCsReq;
        var avatarItem = GachaService.PerformExchangeCeiling(session.Owner, (int)request.AvatarId);
        var packet = new ExchangeGachaCeilingScRsp();

        if (avatarItem is not null)
        {
            packet.GachaCeiling = session.Owner.Gacha.ToCeilingProto(session.Owner);
            packet.GachaType = request.GachaType;
            packet.AvatarId = request.AvatarId;
            packet.TransferItemList.ItemsList.Add(avatarItem.ToProto());
        }
        else
        {
            packet.Retcode = 1;
        }

        session.Send(CmdId.CmdExchangeGachaCeilingScRsp, packet);
    }
}

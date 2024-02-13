using CosmicCore.Protos;
using CosmicCore.Server.Gate.Manager.Handlers.Core;
using CosmicCore.Server.Gate.Network;

namespace CosmicCore.Server.Gate.Manager.Handlers;

public class LineupReqGroup
{
    [PacketHandler(CmdId.CmdSetLineupNameCsReq)]
    public static void OnSetLineupNameCsReq(NetSession session, int cmdId, object data)
    {
        var request = data as SetLineupNameCsReq;
        session.Owner.LineupManager.Lineups[request.Index].Name = request.Name;
        session.Send(CmdId.CmdSetLineupNameScRsp, new SetLineupNameScRsp
        {
            Name = request.Name,
            Index = request.Index
        });
    }

    [PacketHandler(CmdId.CmdGetCurLineupDataCsReq)]
    public static void OnGetCurLineupDataCsReq(NetSession session, int cmdId, object _)
    {
        session.Send(CmdId.CmdGetCurLineupDataScRsp, session.Owner.LineupManager.CurrentLineup.ToProto());
    }

    [PacketHandler(CmdId.CmdGetAllLineupDataCsReq)]
    public static void OnGetAllLineupDataCsReq(NetSession session, int cmdId, object data)
    {
        var response = new GetAllLineupDataScRsp
        {
            CurIndex = (uint)session.Owner.LineupManager.Index
        };
        response.LineupList.AddRange(session.Owner.LineupManager.Lineups.Select(line => line.ToProto()));
        session.Send(CmdId.CmdGetAllLineupDataScRsp, response);
    }

    [PacketHandler(CmdId.CmdChangeLineupLeaderCsReq)]
    public static void OnChangeLineupLeaderCsReq(NetSession session, int cmdId, object data)
    {
        var request = data as ChangeLineupLeaderCsReq;
        session.Owner.LineupManager.CurrentLineup.LeaderIndex = (int)request.Slot;
        session.Send(CmdId.CmdChangeLineupLeaderScRsp, new ChangeLineupLeaderScRsp { Slot = request.Slot });
    }

    [PacketHandler(CmdId.CmdJoinLineupCsReq)]
    public static void OnJoinLineupCsReq(NetSession session, int cmdId, object data)
    {
        var request = data as JoinLineupCsReq;
        session.Owner.LineupManager.Lineups[request.Index].AddAvatar((int)request.BaseAvatarId, (int)request.Slot);
        session.Send(CmdId.CmdJoinLineupScRsp, new JoinLineupCsReq());
    }

    [PacketHandler(CmdId.CmdReplaceLineupCsReq)]
    public static void OnReplaceLineupCsReq(NetSession session, int cmdId, object data)
    {
        var request = data as ReplaceLineupCsReq;
        var lineupList = new List<int>();
        lineupList.AddRange(request.Slots.Select(slot => (int)slot.Id));
        session.Owner.LineupManager.Lineups[request.Index].ReplaceLineup(lineupList);
        session.Send(CmdId.CmdReplaceLineupScRsp, new ReplaceLineupCsReq());
    }

    [PacketHandler(CmdId.CmdQuitLineupCsReq)]
    public static void OnQuitLineupCsReq(NetSession session, int cmdId, object data)
    {
        var request = data as QuitLineupCsReq;
        session.Owner.LineupManager.Lineups[(int)request.Index].RemoveAvatar((int)request.BaseAvatarId);
        session.Send(CmdId.CmdQuitLineupScRsp, new QuitLineupCsReq());
    }

    [PacketHandler(CmdId.CmdSwapLineupCsReq)]
    public static void OnSwapLineupCsReq(NetSession session, int cmdId, object data)
    {
        var request = data as SwapLineupCsReq;
        session.Owner.LineupManager.Lineups[(int)request.Index].SwapAvatar((int)request.SrcSlot, (int)request.DstSlot);
        session.Send(CmdId.CmdSwapLineupScRsp, new SwapLineupCsReq());
    }
}

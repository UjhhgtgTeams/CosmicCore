using CosmicCore.Protos;
using CosmicCore.Server.Gate.Manager.Handlers.Core;
using CosmicCore.Server.Gate.Network;

namespace CosmicCore.Server.Gate.Manager.Handlers;

public class LineupReqGroup
{
    [PacketHandler(CmdId.CmdGetCurLineupDataCsReq)]
    public static void OnGetCurLineupDataCsReq(NetSession session, int cmdId, object _)
    {
        var response = new GetCurLineupDataScRsp
        {
            Retcode = 0,
            Lineup = new LineupInfo
            {
                ExtraLineupType = ExtraLineupType.LineupNone,
                Name = "Squad 1",
                LeaderSlot = 0,
                Mp = 5,
                MaxMp = 5
            }
        };

        var avatars = new[]
        {
            BattleReqGroup.Avatar1, BattleReqGroup.Avatar2, BattleReqGroup.Avatar3, BattleReqGroup.Avatar4
        };
        foreach (var avatar in avatars)
        {
            response.Lineup.AvatarList.Add(avatar.ToLineupAvatar(response.Lineup.AvatarList.Count));
        }

        session.Send(CmdId.CmdGetCurLineupDataScRsp, response);
    }

    [PacketHandler(CmdId.CmdGetAllLineupDataCsReq)]
    public static void OnGetAllLineupDataCsReq(NetSession session, int cmdId, object data)
    {
        var response = new GetAllLineupDataScRsp
        {
            Retcode = 0,
            CurIndex = 0
        };

        response.LineupList.Add(new LineupInfo
        {
            ExtraLineupType = ExtraLineupType.LineupNone,
            Name = "Squad 1",
            Mp = 5,
            MaxMp = 5,
            LeaderSlot = 0
        });

        var avatars = new[]
        {
            BattleReqGroup.Avatar1, BattleReqGroup.Avatar2, BattleReqGroup.Avatar3, BattleReqGroup.Avatar4
        };
        foreach (var avatar in avatars)
        {
            response.LineupList[0].AvatarList.Add(avatar.ToLineupAvatar(response.LineupList[0].AvatarList.Count));
        }

        session.Send(CmdId.CmdGetAllLineupDataScRsp, response);
    }

    [PacketHandler(CmdId.CmdChangeLineupLeaderCsReq)]
    public static void OnChangeLineupLeaderCsReq(NetSession session, int cmdId, object data)
    {
        var request = data as ChangeLineupLeaderCsReq;
        session.Send(CmdId.CmdChangeLineupLeaderScRsp, new ChangeLineupLeaderScRsp
        {
            Retcode = 0,
            Slot = request.Slot
        });
    }

    [PacketHandler(CmdId.CmdJoinLineupCsReq)]
    public static void OnJoinLineupCsReq(NetSession session, int cmdId, object data)
    {
        var request = data as JoinLineupCsReq;
        if (request.Slot == 0) BattleReqGroup.Avatar1.Id = request.BaseAvatarId;
        if (request.Slot == 1) BattleReqGroup.Avatar2.Id = request.BaseAvatarId;
        if (request.Slot == 2) BattleReqGroup.Avatar3.Id = request.BaseAvatarId;
        if (request.Slot == 3) BattleReqGroup.Avatar4.Id = request.BaseAvatarId;
        RefreshLineup(session);

        session.Send(CmdId.CmdJoinLineupScRsp, new JoinLineupScRsp
        {
            Retcode = 0
        });
    }

    [PacketHandler(CmdId.CmdReplaceLineupCsReq)]
    public static void OnReplaceLineupCsReq(NetSession session, int cmdId, object data)
    {
        var request = data as ReplaceLineupCsReq;
        BattleReqGroup.Avatar1.Id = 0;
        BattleReqGroup.Avatar2.Id = 0;
        BattleReqGroup.Avatar3.Id = 0;
        BattleReqGroup.Avatar4.Id = 0;
        foreach (var slotData in request.LineupSlotList)
        {
            if (slotData.Slot == 0) BattleReqGroup.Avatar1.Id = slotData.Id;
            if (slotData.Slot == 1) BattleReqGroup.Avatar2.Id = slotData.Id;
            if (slotData.Slot == 2) BattleReqGroup.Avatar3.Id = slotData.Id;
            if (slotData.Slot == 3) BattleReqGroup.Avatar4.Id = slotData.Id;
        }

        RefreshLineup(session);
        session.Send(CmdId.CmdReplaceLineupScRsp, new ReplaceLineupScRsp
        {
            Retcode = 0
        });
    }

    [PacketHandler(CmdId.CmdQuitLineupCsReq)]
    public static void OnQuitLineupCsReq(NetSession session, int cmdId, object data)
    {
        var request = data as QuitLineupCsReq;
        if (request.BaseAvatarId == BattleReqGroup.Avatar1.Id) BattleReqGroup.Avatar1.Id = 0;
        if (request.BaseAvatarId == BattleReqGroup.Avatar2.Id) BattleReqGroup.Avatar2.Id = 0;
        if (request.BaseAvatarId == BattleReqGroup.Avatar3.Id) BattleReqGroup.Avatar3.Id = 0;
        if (request.BaseAvatarId == BattleReqGroup.Avatar4.Id) BattleReqGroup.Avatar4.Id = 0;

        RefreshLineup(session);
        session.Send(CmdId.CmdQuitLineupScRsp, new QuitLineupScRsp
        {
            Retcode = 0,
            BaseAvatarId = request.BaseAvatarId,
            IsVirtual = request.IsVirtual
        });
    }

    public static void RefreshLineup(NetSession session)
    {
        var avatars = new[]
        {
            BattleReqGroup.Avatar1, BattleReqGroup.Avatar2, BattleReqGroup.Avatar3, BattleReqGroup.Avatar4
        };
        var response = new SyncLineupNotify
        {
            Lineup = new LineupInfo
            {
                ExtraLineupType = ExtraLineupType.LineupNone,
                Name = "Squad 1",
                Mp = 5,
                MaxMp = 5,
                LeaderSlot = 0
            }
        };

        foreach (var avatar in avatars.Where(id => id.Id != 0))
        {
            response.Lineup.AvatarList.Add(avatar.ToLineupAvatar(response.Lineup.AvatarList.Count));
        }

        session.Send(CmdId.CmdSyncLineupNotify, response);
    }
}

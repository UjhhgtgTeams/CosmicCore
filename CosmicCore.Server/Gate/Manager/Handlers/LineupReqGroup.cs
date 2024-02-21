using CosmicCore.Protos;
using CosmicCore.Server.Gate.Manager.Handlers.Core;
using CosmicCore.Server.Gate.Network;
using static CosmicCore.Server.Gate.Manager.Handlers.BattleReqGroup;

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

        var characters = new[] { Avatar1, Avatar2, Avatar3, Avatar4 };
        foreach (var id in characters)
        {
            response.Lineup.AvatarList.Add(new LineupAvatar
            {
                Id = id,
                Hp = 10000,
                Satiety = 100,
                Sp = new AmountInfo { CurAmount = 10000, MaxAmount = 10000 },
                AvatarType = AvatarType.AvatarFormalType,
                Slot = (uint)response.Lineup.AvatarList.Count
            });
        }

        session.Send(CmdId.CmdGetCurLineupDataScRsp, response);
    }

    [PacketHandler(CmdId.CmdGetAllLineupDataCsReq)]
    public static void OnGetAllLineupDataCsReq(NetSession session, int cmdId, object data)
    {
        var response = new GetAllLineupDataScRsp
        {
            Retcode = 0,
            CurIndex = 0,
        };

        response.LineupLists.Add(new LineupInfo
        {
            ExtraLineupType = ExtraLineupType.LineupNone,
            Name = "Squad 1",
            Mp = 5,
            MaxMp = 5,
            LeaderSlot = 0
        });

        var characters = new[] { Avatar1, Avatar2, Avatar3, Avatar4 };
        foreach (var id in characters)
        {
            response.LineupLists[0].AvatarList.Add(new LineupAvatar
            {
                Id = id,
                Hp = 10000,
                Satiety = 100,
                Sp = new AmountInfo { CurAmount = 10000, MaxAmount = 10000 },
                AvatarType = AvatarType.AvatarFormalType,
                Slot = (uint)response.LineupLists[0].AvatarList.Count
            });
        }

        session.Send(CmdId.CmdGetAllLineupDataScRsp, response);
    }

    [PacketHandler(CmdId.CmdChangeLineupLeaderCsReq)]
    public static void OnChangeLineupLeaderCsReq(NetSession session, int cmdId, object data)
    {
        var request = data as ChangeLineupLeaderCsReq;
        session.Send(CmdId.CmdChangeLineupLeaderScRsp, new ChangeLineupLeaderScRsp
        {
            Slot = request.Slot,
            Retcode = 0
        });
    }

    [PacketHandler(CmdId.CmdJoinLineupCsReq)]
    public static void OnJoinLineupCsReq(NetSession session, int cmdId, object data)
    {
        var request = data as JoinLineupCsReq;
        if (request.Slot == 0) Avatar1 = request.BaseAvatarId;
        if (request.Slot == 1) Avatar2 = request.BaseAvatarId;
        if (request.Slot == 2) Avatar3 = request.BaseAvatarId;
        if (request.Slot == 3) Avatar4 = request.BaseAvatarId;
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
        Avatar1 = 0;
        Avatar2 = 0;
        Avatar3 = 0;
        Avatar4 = 0;
        foreach (var slotData in request.LineupSlotList)
        {
            if (slotData.Slot == 0) Avatar1 = slotData.Id;
            if (slotData.Slot == 1) Avatar2 = slotData.Id;
            if (slotData.Slot == 2) Avatar3 = slotData.Id;
            if (slotData.Slot == 3) Avatar4 = slotData.Id;
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
        if (request.BaseAvatarId == Avatar1) Avatar1 = 0;
        if (request.BaseAvatarId == Avatar2) Avatar2 = 0;
        if (request.BaseAvatarId == Avatar3) Avatar3 = 0;
        if (request.BaseAvatarId == Avatar4) Avatar4 = 0;

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
        var characters = new[] { Avatar1, Avatar2, Avatar3, Avatar4 };
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
        foreach (uint id in characters)
        {
            if (id == 0) continue;
            response.Lineup.AvatarList.Add(new LineupAvatar
            {
                Id = id,
                Hp = 10000,
                Satiety = 100,
                Sp = new AmountInfo { CurAmount = 10000, MaxAmount = 10000 },
                AvatarType = AvatarType.AvatarFormalType,
                Slot = (uint)response.Lineup.AvatarList.Count
            });
        }

        session.Send(CmdId.CmdSyncLineupNotify, response);
    }
}

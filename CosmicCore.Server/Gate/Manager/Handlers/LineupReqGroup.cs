using CosmicCore.Server.Utilities;
using CosmicCore.Server.Utilities.Avatar;
using CosmicCore.Protos;
using CosmicCore.Server.Dispatch.Utils;

namespace CosmicCore.Server.Gate.Manager.Handlers;

using Core;
using Network;
using Protos;
using static DefaultAvatarConst;

internal static class LineupReqGroup
{
    [Handler(CmdId.CmdGetCurLineupDataCsReq)]
    public static void OnGetCurLineupDataCsReq(NetSession session, int cmdId, object _)
    {
        var response = new GetCurLineupDataScRsp
        {
            Retcode = (uint)Retcode.Success,
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
            response.Lineup.AvatarLists.Add(new LineupAvatar
            {
                AvatarType = AvatarType.AvatarFormalType,
                Hp = 10000,
                SpBar = new SpBarInfo { CurSp = 10000, MaxSp = 10000 },
                Satiety = 100,
                Id = id,
                Slot = (uint)response.Lineup.AvatarLists.Count
            });

        session.Send(CmdId.CmdGetCurLineupDataScRsp, response);
    }

    [Handler(CmdId.CmdGetAllLineupDataCsReq)]
    public static void OnGetAllLineupDataCsReq(NetSession session, int cmdId, object data)
    {
        var response = new GetAllLineupDataScRsp
        {
            Retcode = (uint)Retcode.Success,
            CurIndex = 0
        };

        response.LineupLists.Add(new LineupInfo
        {
            ExtraLineupType = ExtraLineupType.LineupNone,
            Name = "Squad 1",
            Mp = 5,
            MaxMp = 5,
            LeaderSlot = 0
        });

        var characters = new uint[] { Avatar1, Avatar2, Avatar3, Avatar4 };

        foreach (var id in characters)
            response.LineupLists[0].AvatarLists.Add(new LineupAvatar
            {
                AvatarType = AvatarType.AvatarFormalType,
                SpBar = new SpBarInfo { CurSp = 10000, MaxSp = 10000 },
                Hp = 10000,
                Satiety = 100,
                Id = id,
                Slot = (uint)response.LineupLists[0].AvatarLists.Count
            });

        session.Send(CmdId.CmdGetAllLineupDataScRsp, response);
    }

    [Handler(CmdId.CmdChangeLineupLeaderCsReq)]
    public static void OnChangeLineupLeaderCsReq(NetSession session, int cmdId, object data)
    {
        var request = data as ChangeLineupLeaderCsReq;
        session.Send(CmdId.CmdChangeLineupLeaderScRsp, new ChangeLineupLeaderScRsp
        {
            Slot = request.Slot,
            Retcode = (uint)Retcode.Success
        });
    }

    [Handler(CmdId.CmdJoinLineupCsReq)]
    public static void OnJoinLineupCsReq(NetSession session, int cmdId, object data)
    {
        var request = data as JoinLineupCsReq;
        switch (request.Slot)
        {
            case 0:
                Avatar1 = request.BaseAvatarId;
                break;
            case 1:
                Avatar2 = request.BaseAvatarId;
                break;
            case 2:
                Avatar3 = request.BaseAvatarId;
                break;
            case 3:
                Avatar4 = request.BaseAvatarId;
                break;
        }

        RefreshLineup(session);

        session.Send(CmdId.CmdJoinLineupScRsp, new JoinLineupCsReq());
    }

    [Handler(CmdId.CmdReplaceLineupCsReq)]
    public static void OnReplaceLineupCsReq(NetSession session, int cmdId, object data)
    {
        var request = data as ReplaceLineupCsReq;
        Avatar1 = 0;
        Avatar2 = 0;
        Avatar3 = 0;
        Avatar4 = 0;
        foreach (var slotData in request.Slots)
        {
            Console.WriteLine($"Replace Slot:{slotData.Slot} Id:{slotData.Id}");
            if (slotData.Slot == 0) Avatar1 = slotData.Id;
            if (slotData.Slot == 1) Avatar2 = slotData.Id;
            if (slotData.Slot == 2) Avatar3 = slotData.Id;
            if (slotData.Slot == 3) Avatar4 = slotData.Id;
        }

        RefreshLineup(session);
        session.Send(CmdId.CmdReplaceLineupScRsp, new ReplaceLineupCsReq());
    }

    [Handler(CmdId.CmdQuitLineupCsReq)]
    public static void OnQuitLineupCsReq(NetSession session, int cmdId, object data)
    {
        var request = data as QuitLineupCsReq;
        Console.WriteLine(
            $"CmdQuitLineupCsReq BaseAvatarId:{request.BaseAvatarId} Index:{request.Index} PlaneId:{request.PlaneId}");
        if (request.BaseAvatarId == Avatar1) Avatar1 = 0;
        if (request.BaseAvatarId == Avatar2) Avatar2 = 0;
        if (request.BaseAvatarId == Avatar3) Avatar3 = 0;
        if (request.BaseAvatarId == Avatar4) Avatar4 = 0;

        RefreshLineup(session);
        session.Send(CmdId.CmdQuitLineupScRsp, new QuitLineupCsReq
        {
            BaseAvatarId = request.BaseAvatarId,
            IsVirtual = request.IsVirtual
        });
    }

    public static void RefreshLineup(NetSession session)
    {
        Console.WriteLine($"Team refreshed!{Avatar1} {Avatar2} {Avatar3} {Avatar4}");
        var characters = new uint[] { Avatar1, Avatar2, Avatar3, Avatar4 };
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
        foreach (var id in characters)
        {
            if (id == 0) continue;
            response.Lineup.AvatarLists.Add(new LineupAvatar
            {
                AvatarType = AvatarType.AvatarFormalType,
                SpBar = new SpBarInfo { CurSp = 10000, MaxSp = 10000 },
                Hp = 10000,
                Satiety = 100,
                Id = id,
                Slot = (uint)response.Lineup.AvatarLists.Count
            });
        }

        session.Send(CmdId.CmdSyncLineupNotify, response);
    }
}

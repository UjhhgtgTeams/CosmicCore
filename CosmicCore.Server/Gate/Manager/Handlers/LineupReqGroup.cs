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

        foreach (var avatar in BattleReqGroup.Avatars)
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

        foreach (var avatar in BattleReqGroup.Avatars)
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

        UpdateAvatar((int)request.Slot, (int)request.BaseAvatarId);
        SyncLineup(session);

        session.Send(CmdId.CmdJoinLineupScRsp, new JoinLineupScRsp
        {
            Retcode = 0
        });
    }

    [PacketHandler(CmdId.CmdReplaceLineupCsReq)]
    public static void OnReplaceLineupCsReq(NetSession session, int cmdId, object data)
    {
        var request = data as ReplaceLineupCsReq;

        foreach (var slotData in request.LineupSlotList)
        {
            UpdateAvatar((int)slotData.Slot, (int)slotData.Id);
        }
        SyncLineup(session);

        session.Send(CmdId.CmdReplaceLineupScRsp, new ReplaceLineupScRsp
        {
            Retcode = 0
        });
    }

    [PacketHandler(CmdId.CmdQuitLineupCsReq)]
    public static void OnQuitLineupCsReq(NetSession session, int cmdId, object data)
    {
        var request = data as QuitLineupCsReq;

        BattleReqGroup.Avatars.First(avatar => avatar.Id == request.BaseAvatarId).Id = 0;
        SyncLineup(session);

        session.Send(CmdId.CmdQuitLineupScRsp, new QuitLineupScRsp
        {
            Retcode = 0,
            BaseAvatarId = request.BaseAvatarId,
            IsVirtual = request.IsVirtual
        });
    }

    public static void SyncLineup(NetSession session)
    {
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

        foreach (var avatar in BattleReqGroup.Avatars.Where(id => id.Id != 0))
        {
            response.Lineup.AvatarList.Add(avatar.ToLineupAvatar(response.Lineup.AvatarList.Count));
        }

        session.Send(CmdId.CmdSyncLineupNotify, response);
    }

    public static void UpdateAvatar(int index, int id)
    {
        BattleReqGroup.Avatars[index].Id = id;
        BattleReqGroup.Avatars[index].Weapon =
            BattleReqGroup.Weapons.GetValueOrDefault(index, new AvatarUtil.Weapon(23006, 5));
        BattleReqGroup.Avatars[index].Relics =
            BattleReqGroup.Relics.GetValueOrDefault(index, []);
    }
}

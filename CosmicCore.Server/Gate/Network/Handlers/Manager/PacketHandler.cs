using CosmicCore.Protos;
using CosmicCore.Server.Gate.Manager;
using CosmicCore.Server.Gate.Network.Packet;
using DotNetty.Transport.Channels;
using ProtoBuf;
using Serilog;

namespace CosmicCore.Server.Gate.Network.Handlers.Manager;

public class PacketHandler(NetSession session) : ChannelHandlerAdapter
{
    private static readonly Dictionary<CmdId, CmdId> DummyTable = new()
    {
        { CmdId.CmdGetLevelRewardTakenListCsReq, CmdId.CmdGetLevelRewardTakenListScRsp },
        { CmdId.CmdGetRogueScoreRewardInfoCsReq, CmdId.CmdGetRogueScoreRewardInfoScRsp },
        { CmdId.CmdGetGachaInfoCsReq, CmdId.CmdGetGachaInfoScRsp },
        { CmdId.CmdQueryProductInfoCsReq, CmdId.CmdQueryProductInfoScRsp },
        { CmdId.CmdGetQuestDataCsReq, CmdId.CmdGetQuestDataScRsp },
        { CmdId.CmdGetQuestRecordCsReq, CmdId.CmdGetQuestRecordScRsp },
        { CmdId.CmdGetFriendListInfoCsReq, CmdId.CmdGetFriendListInfoScRsp },
        { CmdId.CmdGetFriendApplyListInfoCsReq, CmdId.CmdGetFriendApplyListInfoScRsp },
        { CmdId.CmdGetCurAssistCsReq, CmdId.CmdGetCurAssistScRsp },
        { CmdId.CmdGetRogueHandbookDataCsReq, CmdId.CmdGetRogueHandbookDataScRsp },
        { CmdId.CmdGetDailyActiveInfoCsReq, CmdId.CmdGetDailyActiveInfoScRsp },
        { CmdId.CmdGetFightActivityDataCsReq, CmdId.CmdGetFightActivityDataScRsp },
        { CmdId.CmdGetMultipleDropInfoCsReq, CmdId.CmdGetMultipleDropInfoScRsp },
        { CmdId.CmdGetPlayerReturnMultiDropInfoCsReq, CmdId.CmdGetPlayerReturnMultiDropInfoScRsp },
        { CmdId.CmdGetShareDataCsReq, CmdId.CmdGetShareDataScRsp },
        { CmdId.CmdGetTreasureDungeonActivityDataCsReq, CmdId.CmdGetTreasureDungeonActivityDataScRsp },
        { CmdId.CmdPlayerReturnInfoQueryCsReq, CmdId.CmdPlayerReturnInfoQueryScRsp },
        { CmdId.CmdGetBasicInfoCsReq, CmdId.CmdGetBasicInfoScRsp },
        { CmdId.CmdGetHeroBasicTypeInfoCsReq, CmdId.CmdGetHeroBasicTypeInfoScRsp },
        { CmdId.CmdGetBagCsReq, CmdId.CmdGetBagScRsp },
        { CmdId.CmdGetPlayerBoardDataCsReq, CmdId.CmdGetPlayerBoardDataScRsp },
        { CmdId.CmdGetAvatarDataCsReq, CmdId.CmdGetAvatarDataScRsp },
        { CmdId.CmdGetAllLineupDataCsReq, CmdId.CmdGetAllLineupDataScRsp },
        { CmdId.CmdGetActivityScheduleConfigCsReq, CmdId.CmdGetActivityScheduleConfigScRsp },
        { CmdId.CmdGetMissionDataCsReq, CmdId.CmdGetMissionDataScRsp },
        { CmdId.CmdGetMissionEventDataCsReq, CmdId.CmdGetMissionEventDataScRsp },
        { CmdId.CmdGetChallengeCsReq, CmdId.CmdGetChallengeScRsp },
        { CmdId.CmdGetCurChallengeCsReq, CmdId.CmdGetCurChallengeScRsp },
        { CmdId.CmdGetRogueInfoCsReq, CmdId.CmdGetRogueInfoScRsp },
        { CmdId.CmdGetExpeditionDataCsReq, CmdId.CmdGetExpeditionDataScRsp },
        { CmdId.CmdGetRogueDialogueEventDataCsReq, CmdId.CmdGetRogueDialogueEventDataScRsp },
        { CmdId.CmdGetJukeboxDataCsReq, CmdId.CmdGetJukeboxDataScRsp },
        { CmdId.CmdSyncClientResVersionCsReq, CmdId.CmdSyncClientResVersionScRsp },
        { CmdId.CmdDailyFirstMeetPamCsReq, CmdId.CmdDailyFirstMeetPamScRsp },
        { CmdId.CmdGetMuseumInfoCsReq, CmdId.CmdGetMuseumInfoScRsp },
        { CmdId.CmdGetLoginActivityCsReq, CmdId.CmdGetLoginActivityScRsp },
        { CmdId.CmdGetRaidInfoCsReq, CmdId.CmdGetRaidInfoScRsp },
        { CmdId.CmdGetTrialActivityDataCsReq, CmdId.CmdGetTrialActivityDataScRsp },
        { CmdId.CmdGetBoxingClubInfoCsReq, CmdId.CmdGetBoxingClubInfoScRsp },
        { CmdId.CmdGetNpcStatusCsReq, CmdId.CmdGetNpcStatusScRsp },
        { CmdId.CmdTextJoinQueryCsReq, CmdId.CmdTextJoinQueryScRsp },
        { CmdId.CmdGetSpringRecoverDataCsReq, CmdId.CmdGetSpringRecoverDataScRsp },
        { CmdId.CmdGetChatFriendHistoryCsReq, CmdId.CmdGetChatFriendHistoryScRsp },
        { CmdId.CmdGetSecretKeyInfoCsReq, CmdId.CmdGetSecretKeyInfoScRsp },
        { CmdId.CmdGetVideoVersionKeyCsReq, CmdId.CmdGetVideoVersionKeyScRsp },
        { CmdId.CmdGetCurLineupDataCsReq, CmdId.CmdGetCurLineupDataScRsp },
        { CmdId.CmdGetCurBattleInfoCsReq, CmdId.CmdGetCurBattleInfoScRsp },
        { CmdId.CmdGetCurSceneInfoCsReq, CmdId.CmdGetCurSceneInfoScRsp },
        { CmdId.CmdGetPhoneDataCsReq, CmdId.CmdGetPhoneDataScRsp },
        { CmdId.CmdPlayerLoginFinishCsReq, CmdId.CmdPlayerLoginFinishScRsp },

        // TODO: the following needs verification
        { CmdId.CmdGetAssistHistoryCsReq, CmdId.CmdGetAssistHistoryScRsp },
        { CmdId.CmdGetCurAssistCsReq, CmdId.CmdGetCurAssistScRsp },
        { CmdId.CmdGetAssistListCsReq, CmdId.CmdGetAssistListScRsp },
        { CmdId.CmdGetFriendAssistListCsReq, CmdId.CmdGetFriendAssistListScRsp }
        // { CmdId.CmdSetClientPausedCsReq, CmdId.CmdSetClientPausedScRsp }
    };

    public override void ChannelRead(IChannelHandlerContext context, object message)
    {
        var packet = message as NetPacket;

        // TODO: verify: changed handle priority to use registered handler first instead of dummy responses
        // if (packet.Data == null)
        // {
        //     Log.Information("Received null packet with cmd id {0}({1})",
        //         (CmdId)packet.CmdId, packet.CmdId);
        //
        //     if (SendDummyResponse(packet.CmdId))
        //     {
        //         Log.Information("Responded with dummy response");
        //         return;
        //     }
        //     else
        //         Log.Warning("Packet cmd id does not have dummy response! Trying registered handlers...");
        // }
        // NotifyManager.Notify(session, packet.CmdId, packet.Data);

        var notifySucceeded = NotifyManager.Notify(session, packet.CmdId, packet.Data);
        if (!notifySucceeded)
        {
            var dummySucceeded = false;

            if (packet.Data is null)
                if (SendDummyResponse(packet.CmdId))
                {
                    Log.Information("{0}({1}): Responded with dummy response", (CmdId)packet.CmdId, packet.CmdId);
                    dummySucceeded = true;
                }

            if (!dummySucceeded)
                Log.Error("{0}({1}): Does not have any handler!", (CmdId)packet.CmdId, packet.CmdId);
        }
    }

    private bool SendDummyResponse(int id)
    {
        if (DummyTable.TryGetValue((CmdId)id, out var rspId))
        {
            session.Send(rspId, new DummyPacket());
            return true;
        }

        return false;
    }

    [ProtoContract]
    public class DummyPacket;
}

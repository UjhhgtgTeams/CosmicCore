using System.Collections.Immutable;
using CosmicCore.Protos;
using ProtoBuf;

namespace CosmicCore.Server.Gate.Network.Factory;


internal static class ProtoFactory
{
    private static readonly ImmutableDictionary<CmdId, Type> STypes;

    static ProtoFactory()
    {
        var builder = ImmutableDictionary.CreateBuilder<CmdId, Type>();
        builder.AddRange(new Dictionary<CmdId, Type>
        {
            { CmdId.CmdPlayerGetTokenCsReq, typeof(PlayerGetTokenCsReq) },
            { CmdId.CmdPlayerLoginCsReq, typeof(PlayerLoginScRsp)}, // FIXME
            { CmdId.CmdGetAvatarDataCsReq, typeof(GetAvatarDataCsReq) },

            { CmdId.CmdGetAllLineupDataCsReq, typeof(GetAllLineupDataScRsp) }, // FIXME
            { CmdId.CmdGetCurLineupDataCsReq, typeof(GetCurLineupDataScRsp) }, // FIXME
            { CmdId.CmdChangeLineupLeaderCsReq, typeof(ChangeLineupLeaderCsReq) },

            { CmdId.CmdGetMissionStatusCsReq, typeof(GetMissionStatusCsReq) },
            { CmdId.CmdGetQuestDataCsReq, typeof(GetQuestDataCsReq) },
            { CmdId.CmdGetChallengeCsReq, typeof(GetChallengeScRsp) }, // FIXME
            { CmdId.CmdGetCurSceneInfoCsReq, typeof(GetCurSceneInfoScRsp) }, // FIXME

            { CmdId.CmdGetBasicInfoCsReq, typeof(GetBasicInfoScRsp) }, // FIXME
            { CmdId.CmdGetHeroBasicTypeInfoCsReq, typeof(GetHeroBasicTypeInfoScRsp) },
            { CmdId.CmdPlayerHeartBeatCsReq, typeof(PlayerHeartbeatCsReq) },

            { CmdId.CmdGetGachaInfoCsReq, typeof(GetGachaInfoScRsp) }, // FIXME
            { CmdId.CmdDoGachaCsReq, typeof(DoGachaCsReq) },

            { CmdId.CmdGetNpcTakenRewardCsReq, typeof(GetNpcTakenRewardCsReq) },
            { CmdId.CmdGetFirstTalkByPerformanceNpcCsReq, typeof(GetFirstTalkNpcCsReq) },

            { CmdId.CmdSceneEntityMoveCsReq, typeof(SceneEntityMoveCsReq) },
            { CmdId.CmdReplaceLineupCsReq, typeof(ReplaceLineupCsReq) },

            { CmdId.CmdJoinLineupCsReq, typeof(JoinLineupCsReq) },
            { CmdId.CmdQuitLineupCsReq, typeof(QuitLineupCsReq) },
            { CmdId.CmdSwapLineupCsReq, typeof(SwapLineupCsReq) },

            { CmdId.CmdSetLineupNameCsReq, typeof(SetLineupNameCsReq) },
            { CmdId.CmdStartCocoonStageCsReq, typeof(StartCocoonStageCsReq) },
            { CmdId.CmdPVEBattleResultCsReq, typeof(PVEBattleResultCsReq) }
        });

        STypes = builder.ToImmutable();
    }

    public static object? Deserialize(int id, byte[] rawData)
    {
        return STypes.TryGetValue((CmdId)id, out var type)
            ? Serializer.Deserialize(type, new MemoryStream(rawData))
            : null;
    }
}

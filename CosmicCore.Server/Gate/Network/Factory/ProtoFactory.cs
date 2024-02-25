using System.Collections.Immutable;
using CosmicCore.Protos;
using ProtoBuf;

namespace CosmicCore.Server.Gate.Network.Factory;

public static class ProtoFactory
{
    private static readonly ImmutableDictionary<CmdId, Type> Types;

    static ProtoFactory()
    {
        var builder = ImmutableDictionary.CreateBuilder<CmdId, Type>();
        builder.AddRange(new Dictionary<CmdId, Type>
        {
            { CmdId.CmdPlayerGetTokenCsReq, typeof(PlayerGetTokenCsReq) },
            { CmdId.CmdPlayerLoginCsReq, typeof(PlayerLoginCsReq) },
            { CmdId.CmdGetAvatarDataCsReq, typeof(GetAvatarDataCsReq) },

            { CmdId.CmdGetAllLineupDataCsReq, typeof(GetAllLineupDataCsReq) },
            { CmdId.CmdGetCurLineupDataCsReq, typeof(GetCurLineupDataCsReq) },
            { CmdId.CmdChangeLineupLeaderCsReq, typeof(ChangeLineupLeaderCsReq) },

            { CmdId.CmdGetMissionStatusCsReq, typeof(GetMissionStatusCsReq) },
            // { CmdId.CmdGetQuestDataCsReq, typeof(GetQuestDataCsReq) },
            // { CmdId.CmdGetChallengeCsReq, typeof(GetChallengeCsReq) },
            { CmdId.CmdGetCurSceneInfoCsReq, typeof(GetCurSceneInfoCsReq) },
            { CmdId.CmdGetSceneMapInfoCsReq, typeof(GetSceneMapInfoCsReq) },

            { CmdId.CmdGetBasicInfoCsReq, typeof(GetBasicInfoCsReq) },
            { CmdId.CmdGetHeroBasicTypeInfoCsReq, typeof(GetHeroBasicTypeInfoCsReq) },
            { CmdId.CmdPlayerHeartBeatCsReq, typeof(PlayerHeartBeatCsReq) },

            // { CmdId.CmdGetGachaInfoCsReq, typeof(GetGachaInfoCsReq) },
            // { CmdId.CmdDoGachaCsReq, typeof(DoGachaCsReq) },

            { CmdId.CmdGetNpcTakenRewardCsReq, typeof(GetNpcTakenRewardCsReq) },
            { CmdId.CmdGetFirstTalkByPerformanceNpcCsReq, typeof(GetFirstTalkByPerformanceNpcCsReq) },

            { CmdId.CmdSceneEntityMoveCsReq, typeof(SceneEntityMoveCsReq) },
            { CmdId.CmdReplaceLineupCsReq, typeof(ReplaceLineupCsReq) },

            { CmdId.CmdJoinLineupCsReq, typeof(JoinLineupCsReq) },
            { CmdId.CmdQuitLineupCsReq, typeof(QuitLineupCsReq) },
            { CmdId.CmdSwapLineupCsReq, typeof(SwapLineupCsReq) },

            { CmdId.CmdSetLineupNameCsReq, typeof(SetLineupNameCsReq) },
            { CmdId.CmdStartCocoonStageCsReq, typeof(StartCocoonStageCsReq) },
            { CmdId.CmdPVEBattleResultCsReq, typeof(PVEBattleResultCsReq) }

            // TODO: this is tricky, needs verification
            // { CmdId.CmdGetTutorialCsReq, typeof(PacketHandler.DummyPacket) },
            // { CmdId.CmdGetTutorialGuideCsReq, typeof(PacketHandler.DummyPacket) },
            // { CmdId.CmdPlayerLogoutCsReq, typeof(PacketHandler.DummyPacket) }
        });

        Types = builder.ToImmutable();
    }

    public static object? Deserialize(int id, byte[] rawData)
    {
        return Types.TryGetValue((CmdId)id, out var type)
            ? Serializer.Deserialize(type, new MemoryStream(rawData))
            : null;
    }
}

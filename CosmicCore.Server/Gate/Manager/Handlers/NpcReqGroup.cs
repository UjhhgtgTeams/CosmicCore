using CosmicCore.Server.Gate.Manager.Handlers.Core;
using CosmicCore.Server.Gate.Network;
using CosmicCore.Server.Utilities;
using CosmicCore.Protos;
using CosmicCore.Server.Dispatch.Utils;

namespace CosmicCore.Server.Gate.Manager.Handlers;

internal static class NpcReqGroup
{
    //maybe useless
    [Handler(CmdId.CmdGetNpcTakenRewardCsReq)]
    public static void OnGetNpcTakenRewardCsReq(NetSession session, int cmdId, object data)
    {
        var npcRewardReq = data as GetNpcTakenRewardCsReq;

        session.Send(CmdId.CmdGetNpcTakenRewardScRsp, new GetNpcTakenRewardScRsp
        {
            NpcId = npcRewardReq.NpcId,
            Retcode = (uint)Retcode.Success
        });
    }

    [Handler(CmdId.CmdGetFirstTalkByPerformanceNpcCsReq)]
    public static void OnGetFirstTalkByPerformanceNpcCsReq(NetSession session, int cmdId, object data)
    {
        var npcPerformanceReq = data as GetFirstTalkByPerformanceNpcCsReq;

        var response = new GetFirstTalkByPerformanceNpcScRsp
        {
            Retcode = (uint)Retcode.Success
        };

        foreach (var id in npcPerformanceReq.NpcTalkList)
            response.NpcTalkInfoList.Add(new NpcTalkInfo
            {
                NpcTalkId = id
            });

        session.Send(CmdId.CmdGetFirstTalkByPerformanceNpcScRsp, response);
    }
}

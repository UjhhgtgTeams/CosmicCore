using CosmicCore.Protos;
using CosmicCore.Server.Gate.Manager.Handlers.Core;
using CosmicCore.Server.Gate.Network;

namespace CosmicCore.Server.Gate.Manager.Handlers;

public class NpcReqGroup
{
    [PacketHandler(CmdId.CmdGetNpcTakenRewardCsReq)]
    public static void OnGetNpcTakenRewardCsReq(NetSession session, int cmdId, object data)
    {
        var npcRewardReq = data as GetNpcTakenRewardCsReq;

        session.Send(CmdId.CmdGetNpcTakenRewardScRsp, new GetNpcTakenRewardScRsp
        {
            NpcId = npcRewardReq.NpcId,
            Retcode = 0
        });
    }

    [PacketHandler(CmdId.CmdGetFirstTalkByPerformanceNpcCsReq)]
    public static void OnGetFirstTalkByPerformanceNpcCsReq(NetSession session, int cmdId, object data)
    {
        var npcPerformanceReq = data as GetFirstTalkByPerformanceNpcCsReq;

        var response = new GetFirstTalkByPerformanceNpcScRsp
        {
            Retcode = 0
        };

        foreach (var id in npcPerformanceReq.FirstTalkIdLists)
        {
            response.NpcMeetStatusList.Add(new NpcMeetStatusInfo
            {
                IsMeet = true,
                MeetId = id
            });

        }

        session.Send(CmdId.CmdGetFirstTalkByPerformanceNpcScRsp, response);
    }
}

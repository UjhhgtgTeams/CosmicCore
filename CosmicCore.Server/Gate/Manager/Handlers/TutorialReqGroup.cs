using CosmicCore.Protos;
using CosmicCore.Server.Gate.Manager.Handlers.Core;
using CosmicCore.Server.Gate.Network;

namespace CosmicCore.Server.Gate.Manager.Handlers;

public class TutorialReqGroup
{
    [PacketHandler(CmdId.CmdGetTutorialGuideCsReq)]
    public static void OnGetTutorialGuideCsReq(NetSession session, int cmdId, object data)
    {
        var response = new GetTutorialGuideScRsp
        {
            Retcode = 0
        };

        var guides = new uint[]
        {
            1101, 1102, 1104, 1105, 1116, 1117, 2006, 2007, 2101, 2105, 2106, 2107, 3007, 3105, 3106, 4001, 4101, 4102,
            4103, 4104, 4105, 4106, 4107, 4108, 4109, 5101, 5102, 5103, 5104, 5105, 6001, 6002, 6003, 6004, 6005, 6006,
            6007, 9101, 9102, 9103, 9104, 9105, 9106, 9107, 9108
        };

        foreach (var id in guides)
        {
            response.TutorialGuideList.Add(new TutorialGuide
            {
                Id = id,
                Status = TutorialStatus.TutorialFinish
            });
        }

        session.Send(CmdId.CmdGetTutorialGuideScRsp, response);
    }

    [PacketHandler(CmdId.CmdGetTutorialCsReq)]
    public static void OnGetTutorialCsReq(NetSession session, int cmdId, object data)
    {
        var completedTutorials = new uint[]
        {
            1001, 1002, 1003, 1004, 1005, 1007, 1008, 1010, 1011,
            2001, 2002, 2003, 2004, 2005, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015,
            3001, 3002, 3003, 3004, 3005, 3006,
            4002, 4003, 4004, 4005, 4006, 4007, 4008, 4009,
            5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009, 5010, 5011, 5012,
            7001,
            9001, 9002, 9003, 9004, 9005, 9006
        };

        var response = new GetTutorialScRsp
        {
            Retcode = 0
        };

        foreach (var id in completedTutorials)
        {
            response.TutorialList.Add(new Tutorial
            {
                Id = id,
                Status = TutorialStatus.TutorialFinish
            });
        }

        session.Send(CmdId.CmdGetTutorialScRsp, response);
    }
}

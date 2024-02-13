using CosmicCore.Server.Utilities;

namespace CosmicCore.Server.Gate.Manager.Handlers;

using Core;
using Network;
using Protos;

public class SceneReqGroup
{
    [PacketHandler(CmdId.CmdGetCurSceneInfoCsReq)]
    public static void OnGetCurSceneInfoCsReq(NetSession session, int cmdId, object data)
    {
        var scene = new SceneInfo
        {
            GameModeType = 1,
            // Bkmbkahohif = 1,
            // Admbbnbnibk = 1,
            EntryId = 1030101,
            PlaneId = 10301,
            FloorId = 10301001
        };

        // scene.EntityLists.Add(new SceneEntityInfo
        // {
        //     EntityId = 0,
        //     GroupId = 0,
        //     InstId = 0,
        //     Motion = new MotionInfo
        //     {
        //         Pos = new Vector(),
        //         Rot = new Vector()
        //     }
        // });

        session.Send(CmdId.CmdGetCurSceneInfoScRsp, new GetCurSceneInfoScRsp
        {
            Scene = scene,
            Retcode = (uint)Retcode.Success
        });
    }
}

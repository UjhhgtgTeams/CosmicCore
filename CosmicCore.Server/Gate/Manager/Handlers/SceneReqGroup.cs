using CosmicCore.Protos;
using CosmicCore.Server.Gate.Manager.Handlers.Core;
using CosmicCore.Server.Gate.Network;

namespace CosmicCore.Server.Gate.Manager.Handlers;

public class SceneReqGroup
{
    public static List<MotionInfo> PlayerPosition = [];

    [PacketHandler(CmdId.CmdGetCurSceneInfoCsReq)]
    public static void OnGetCurSceneInfoCsReq(NetSession session, int cmdId, object data)
    {
        var scene = new SceneInfo
        {
            GameModeType = 1,
            PlaneId = Const.StartPlaneId,
            FloorId = Const.StartFloorId,
            EntryId = Const.StartEntryId
        };

        session.Send(CmdId.CmdGetCurSceneInfoScRsp, new GetCurSceneInfoScRsp
        {
            Retcode = 0,
            Scene = scene
        });
    }

    [PacketHandler(CmdId.CmdGetSceneMapInfoCsReq)]
    public static void OnGetSceneMapInfoCsReq(NetSession session, int cmdId, object data)
    {
        var request = data as GetSceneMapInfoCsReq;

        uint[] back =
        [
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29,
            30, 31, 32, 33, 34, 0
        ];

        var mapinfo = new SceneMapInfo
        {
            Retcode = 0,
            LightenSectionList = back,
            ChestList =
            {
                new ChestInfo
                {
                    ChestType = ChestType.MapInfoChestTypeNormal
                },
                new ChestInfo
                {
                    ChestType = ChestType.MapInfoChestTypePuzzle
                },
                new ChestInfo
                {
                    ChestType = ChestType.MapInfoChestTypeChallenge
                }
            }
        };

        var response = new GetSceneMapInfoScRsp
        {
            Retcode = 0,
            EntryId = request.EntryIdList[0],
            CurrentMapEntryId = request.EntryId,
            SceneMapInfoList = { mapinfo },
            LightenSectionList = back
        };

        session.Send(CmdId.CmdGetSceneMapInfoScRsp, response);
    }

    [PacketHandler(CmdId.CmdSceneEntityMoveCsReq)]
    public static void OnSceneEntityMoveCsReq(NetSession session, int cmdId, object data)
    {
        var request = data as SceneEntityMoveCsReq;
        // var response = new SceneEntityMoveScRsp
        // {
        //     Retcode = 0
        // };
        // response.EntityMotionList.AddRange(request.EntityMotionList);

        Interlocked.Exchange(ref PlayerPosition, request.EntityMotionList.Select(em => em.Motion).ToList());

        // session.Send(CmdId.CmdSceneEntityMoveScRsp, response);
    }

    // [PacketHandler(CmdId.CmdSceneCastSkillCsReq)]
    // public static void OnSceneCastSkillCsReq(NetSession session, int cmdId, object data)
    // {
    //     session.Send(CmdId.CmdSceneCastSkillScRsp, new PacketHandler.DummyPacket()); // FIXME: testing
    // }

    // [PacketHandler(CmdId.CmdSceneCastSkillCostMpCsReq)]
    // public static void OnSceneCastSkillCostMpCsReq(NetSession session, int cmdId, object data)
    // {
    //     var request = data as Protos.
    // }
}

using CosmicCore.Protos;
using CosmicCore.Server.Gate.Manager.Handlers.Core;
using CosmicCore.Server.Gate.Network;
using CosmicCore.Server.Utilities;

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

        var mapInfo = new SceneMapInfo
        {
            Retcode = 0,
            LightenSectionList = ListUtils.FromUIntRange(0, 99).ToArray(),
            EntryId = request.EntryIdList[0],
            ChestList =
            {
                new SceneChestInfo
                {
                    ChestType = ChestType.MapInfoChestTypeNormal,
                    TotalAmount = 1
                },
                new SceneChestInfo
                {
                    ChestType = ChestType.MapInfoChestTypePuzzle,
                    TotalAmount = 1
                },
                new SceneChestInfo
                {
                    ChestType = ChestType.MapInfoChestTypeChallenge,
                    TotalAmount = 1
                }
            }
        };

        var response = new GetSceneMapInfoScRsp
        {
            Retcode = 0,
            EntryId = request.EntryIdList[0],
            LightenSectionList = ListUtils.FromUIntRange(0, 99).ToArray(),
            CurrentMapEntryId = request.EntryId,
            SceneMapInfoList = { mapInfo }
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

        // use interlocked for thread safety
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

using CosmicCore.Protos;
using CosmicCore.Server.Gate.Manager.Handlers.Core;
using CosmicCore.Server.Gate.Network;
using CosmicCore.Server.Utilities;

namespace CosmicCore.Server.Gate.Manager.Handlers;

public class SceneReqGroup
{
    [PacketHandler(CmdId.CmdGetCurSceneInfoCsReq)]
    public static void OnGetCurSceneInfoCsReq(NetSession session, int cmdId, object data)
    {
        var scene = new SceneInfo
        {
            GameModeType = 1,
            //Bkmbkahohif = 1,
            //Admbbnbnibk = 1,
            EntryId = 2032101,
            PlaneId = 20321,
            FloorId = 20321001
        };

        // scene.EntityList.Add(new SceneEntityInfo
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
            Retcode = (uint)Retcode.Success,
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
            CurMapEntryId = request.EntryId,
            SceneMapInfoes = { mapinfo },
            LightenSectionLists = back
        };

        session.Send(CmdId.CmdGetSceneMapInfoScRsp, response);
    }
}

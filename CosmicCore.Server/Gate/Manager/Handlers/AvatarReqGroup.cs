using CosmicCore.Protos;
using CosmicCore.Server.Gate.Manager.Handlers.Core;
using CosmicCore.Server.Gate.Network;

namespace CosmicCore.Server.Gate.Manager.Handlers;

public class AvatarReqGroup
{
    [PacketHandler(CmdId.CmdGetAvatarDataCsReq)]
    public static void OnGetAvatarDataCsReq(NetSession session, int cmdId, object data)
    {
        var request = data as GetAvatarDataCsReq;

        var response = new GetAvatarDataScRsp
        {
            Retcode = 0,
            IsAll = request.IsGetAll
        };

        var characters = new List<uint>
        {
            8001, 8002, 8003, 8004,
            1001, 1002, 1003, 1004, 1005, 1006, 1008, 1009, 1013,
            1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108, 1109, 1110, 1111, 1112,
            1201, 1202, 1203, 1204, 1205, 1206, 1207, 1208, 1209, 1210, 1211, 1212, 1213, 1214, 1215, 1217,
            1301, 1302, 1303, 1304, 1305, 1306, 1307, 1308, 1312
        };

        foreach (var id in characters)
        {
            // TODO: needs hang-up verification; old: the commented part seemed to hang this packet up
            response.AvatarList.Add(new AvatarUtil.Avatar(id, 6, null,
                BattleReqGroup.Relics.GetValueOrDefault(id) ?? []));
        }

        session.Send(CmdId.CmdGetAvatarDataScRsp, response);
    }
}

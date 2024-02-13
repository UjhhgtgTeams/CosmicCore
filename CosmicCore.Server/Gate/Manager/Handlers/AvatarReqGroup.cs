using CosmicCore.Server.Gate.Manager.Handlers.Core;
using CosmicCore.Server.Gate.Network;
using CosmicCore.Server.Utilities;
using CosmicCore.Protos;
using CosmicCore.Server.Utilities.Resource;

namespace CosmicCore.Server.Gate.Manager.Handlers;

public class AvatarReqGroup
{
    [PacketHandler(CmdId.CmdGetAvatarDataCsReq)]
    public static void OnGetAvatarDataCsReq(NetSession session, int cmdId, object data)
    {
        var request = data as GetAvatarDataCsReq;

        var response = new GetAvatarDataScRsp
        {
            Retcode = (uint)Retcode.Success,
            IsGetAll = request.IsGetAll
        };

        var characters = ResourceManager.AvatarExcels.Select(avatar => (uint)avatar.Id);

        foreach (var id in characters)
        {
            var avatarData = new Avatar
            {
                BaseAvatarId = id,
                Exp = 0,
                Level = 80,
                Promotion = 6,
                Rank = 6,
                EquipmentUniqueId = 0
            };

            var skillIdEnds = new List<uint> // FIXME: hardcode
                { 1, 2, 3, 4, 7, 101, 102, 103, 201, 202, 203, 204, 205, 206, 207, 208, 209, 210 };

            foreach (var end in skillIdEnds)
            {
                avatarData.SkilltreeList.Add(new AvatarSkillTree
                {
                    PointId = id * 1000 + end,
                    Level = 1
                });
            }

            response.AvatarLists.Add(avatarData);
        }

        session.Send(CmdId.CmdGetAvatarDataScRsp, response);
    }
}

using CosmicCore.Protos;
using CosmicCore.Server.Gate.Manager.Handlers.Core;
using CosmicCore.Server.Gate.Network;
using CosmicCore.Server.Utilities.Config;

namespace CosmicCore.Server.Gate.Manager.Handlers;

public class FriendReqGroup
{
    [PacketHandler(CmdId.CmdGetFriendListInfoCsReq)]
    public static void OnGetFriendListInfoCsReq(NetSession session, int cmdId, object data)
    {
        var serverFriendInfo = ConfigManager.Config.ServerOptions.ServerFriendInfo;

        var serverFriend = new SimpleInfo
        {
            Uid = (uint)Const.ServerConsoleId,
            Nickname = serverFriendInfo.Name,
            Signature = serverFriendInfo.Signature,
            Level = (uint)serverFriendInfo.Level,
            ChatBubbleId = (uint)serverFriendInfo.ChatBubbleId,
            OnlineStatus = FriendOnlineStatus.FriendOnlineStatusOnline,
            PlatformType = PlatformType.Pc,
            HeadIcon = (uint)serverFriendInfo.HeadIcon
        };
        serverFriend.AssistSimpleInfos.Add(new AssistSimpleInfo
        {
            AvatarId = (uint)Const.ServerConsoleId,
            Level = (uint)serverFriendInfo.Level
        });

        // TODO: add friends support

        var packet = new GetFriendListInfoScRsp();
        packet.FriendList.Add(new FriendListInfo { SimpleInfo = serverFriend });

        session.Send(CmdId.CmdGetFriendListInfoScRsp, packet);
    }
}

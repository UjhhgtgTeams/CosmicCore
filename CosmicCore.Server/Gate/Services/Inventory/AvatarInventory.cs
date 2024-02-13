using CosmicCore.Protos;
using CosmicCore.Server.Utilities.Account;

namespace CosmicCore.Server.Gate.Services.Inventory;

public class AvatarInventory(Account account) : AccountManager(account)
{
    public Dictionary<int, Avatar> Avatars { get; } = [];
    public Dictionary<int, Avatar.AvatarHeroPath> HeroPaths { get; } = [];

    public bool HasAvatar(int avatarId)
    {
        return Avatars.ContainsKey(avatarId);
    }

    public bool HasAvatar(Avatar avatar)
    {
        return HasAvatar(avatar.AvatarId);
    }

    public bool AddAvatar(Avatar avatar)
    {
        if (avatar.Excel is null || Avatars.ContainsKey(avatar.AvatarId))
        {
            return false;
        }

        if (avatar.IsHero && Avatars.ContainsKey(Const.TrailblazerAvatarId) && !DebugValues.AllowMultipleMainCharacters)
        {
            return false;
        }

        avatar.Owner = Owner;
        Avatars.Add(avatar.AvatarId, avatar);

        var packet = new PlayerSyncScNotify();
        packet.AvatarSync.AvatarList.Add(avatar.ToProto());
        if (avatar.HeroPath is not null)
        {
            packet.BasicTypeInfoList.Add(avatar.HeroPath.ToProto());
        }
        Owner.Session.Send(CmdId.CmdPlayerSyncScNotify, packet);

        Owner.Unlocks.AddHeadIcon(avatar.HeadIconId);

        return true;
    }
}

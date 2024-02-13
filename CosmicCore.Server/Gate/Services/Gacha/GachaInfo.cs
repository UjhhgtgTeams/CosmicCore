using CosmicCore.Protos;
using CosmicCore.Server.Utilities.Account;

namespace CosmicCore.Server.Gate.Services.Gacha;

public class GachaInfo(Account account) : AccountManager(account)
{
    public GachaBannerInfo StandardBanner { get; } = new();
    public GachaBannerInfo AvatarUpBanner { get; } = new();
    public GachaBannerInfo WeaponUpBanner { get; } = new();
    public int? Ceiling { get; set; } = 0; // reminder: null value means that ceiling has been claimed

    public void AddCeiling(int amount)
    {
        if (Ceiling is null)
            throw new InvalidOperationException("cannot add ceiling when ceiling has already been claimed");
        Ceiling = Math.Min((Ceiling ?? 0) + amount, Const.MaxGachaCeiling);
    }

    public GachaBannerInfo GetBannerInfo(GachaType type)
    {
        return type switch
        {
            GachaType.AvatarUp => AvatarUpBanner,
            GachaType.WeaponUp => WeaponUpBanner,
            _ => StandardBanner
        };
    }

    public GachaCeiling ToCeilingProto(Account account)
    {
        var proto = new GachaCeiling
        {
            IsClaimed = Ceiling is null,
            CeilingNum = (uint)(Ceiling ?? 0)
        };

        foreach (var avatarId in GachaService.DefaultYellowAvatars)
        {
            var repeatedCnt = 0;
            if (account.AvatarInventory.Avatars.TryGetValue(avatarId, out var avatar))
            {
                repeatedCnt = avatar.Data.Rank;
            }

            var ceilingAvatar = new GachaCeilingAvatar
            {
                RepeatedCnt = (uint)repeatedCnt,
                AvatarId = (uint)avatarId
            };

            proto.AvatarList.Add(ceilingAvatar);
        }

        return proto;
    }

    public class GachaBannerInfo
    {
        public int Pity5 { get; set; }
        public int Pity4 { get; set; }
        public int FailedFeaturedItemPulls { get; set; }
    }
}

namespace CosmicCore.Server.Gate.Services.Gacha;

public enum GachaType
{
    // works as an enum with list values
    Unknown = 0,
    Newbie = 1,
    Normal = 2,
    AvatarUp = 11,
    WeaponUp = 12
}

public static class GachaTypeExtensionMethods
{
    public static int CostItem(this GachaType type)
    {
        return type switch
        {
            GachaType.Unknown => 0,
            GachaType.Newbie => 101,
            GachaType.Normal => 101,
            GachaType.AvatarUp => 102,
            GachaType.WeaponUp => 102,
            _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
        };
    }

    public static int Min(this GachaType type)
    {
        return type switch
        {
            GachaType.Unknown => 0,
            GachaType.Newbie => 1,
            GachaType.Normal => 1,
            GachaType.AvatarUp => 1,
            GachaType.WeaponUp => 2,
            _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
        };
    }

    public static int Max(this GachaType type)
    {
        return type switch
        {
            GachaType.Unknown => 0,
            GachaType.Newbie => 2,
            GachaType.Normal => 2,
            GachaType.AvatarUp => 1,
            GachaType.WeaponUp => 2,
            _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
        };
    }
}

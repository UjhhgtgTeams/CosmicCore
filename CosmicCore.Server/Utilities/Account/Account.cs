using CosmicCore.Protos;
using CosmicCore.Server.Gate.Network;
using CosmicCore.Server.Gate.Services.Inventory;
using CosmicCore.Server.Gate.Services.Lineup;
using CosmicCore.Server.Gate.Services.Mail;
using CosmicCore.Server.Utilities.Chat;
using CosmicCore.Server.Utilities.Config;
using Serilog;
using GachaInfo = CosmicCore.Server.Gate.Services.Gacha.GachaInfo;

namespace CosmicCore.Server.Utilities.Account;

public class Account : IEquatable<Account>
{
    public static readonly Account Console = new(Const.ServerConsoleId, "Console", "") { Permissions = ["*"] };

    public Account(long id, string username, string password)
    {
        Id = id;
        UserName = username;
        Password = password;
        ComboToken = Cryptography.MiHoYoEncryption.GetSessionKey(Id);
        DispatchToken = Cryptography.MiHoYoEncryption.GetSessionKey(Id);

        NickName = UserName;
        Currency = new CurrencyInventory(this);
        AvatarInventory = new AvatarInventory(this);
        Unlocks = new UnlockInfo(this);
        Inventory = new Inventory(this);
        Mailbox = new Mailbox(this);
        PrivateChat = new ChatManager(this);
        LineupManager = new LineupManager(this);
        Gacha = new GachaInfo(this);

        Log.Debug("Initiated a new Account class with id {0}, username {1} and password {2}", id, username, password);
    }

    public long Id { get; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string EmailAddress => UserName + "@" + Const.Name.ToLower() + ".com";
    public string ComboToken { get; set; }
    public string DispatchToken { get; set; }
    private HashSet<string> Permissions { get; init; } = [];

    public bool Equals(Account? other)
    {
        if (other is null) return false;
        return Id == other.Id;
    }

    public BoardDataSync ToBoardDataProto()
    {
        var proto = new BoardDataSync
        {
            Signature = Signature
        };
        proto.UnlockedHeadIconList.AddRange(Unlocks.HeadIcons.Select(headIcon => new HeadIcon
        {
            Id = (uint)headIcon
        }));
        return proto;
    }

    public bool HasPermission(string permission)
    {
        Log.Debug("Running permission check for permission {Permission} and account {Id}/{UserName}", permission, Id,
            UserName);
        if (string.IsNullOrWhiteSpace(permission)) return true;
        var defaultPermissions = ConfigManager.Config.ServerOptions.DefaultPermissions;
        var permissions = Permissions.ToList();
        permissions.AddRange(defaultPermissions);
        permissions = permissions.Distinct().ToList();

        var permissionParts = permission.Split("\\.");
        foreach (var p in permissions)
        {
            if (p.StartsWith('-') && HasPermissionWildcard(p[1..], permissionParts)) return false;
            if (HasPermissionWildcard(p, permissionParts)) return true;
        }

        return permission.Contains('*');
    }

    public bool HasPermissions(IEnumerable<string> permissions)
    {
        return permissions.All(HasPermission);
    }

    private static bool HasPermissionWildcard(string wildcard, IReadOnlyList<string> permissionParts)
    {
        var wildcardParts = wildcard.Split("\\.").ToList();
        if (permissionParts.Count < wildcardParts.Count) return false;

        foreach (var wildcardPart in wildcardParts)
            switch (wildcardPart)
            {
                case "**":
                    return true;

                case "*":
                    if (wildcardParts.IndexOf(wildcardPart) >= permissionParts.Count - 1) return true;
                    break;

                default:
                    if (wildcardPart != permissionParts[wildcardParts.IndexOf(wildcardPart)]) return false;
                    break;
            }

        return wildcardParts.Count == permissionParts.Count;
    }

    // public void UpdateStamina(long timestamp)
    // {
    //     var hasChanged = false;
    //
    //     while (timestamp >= NextStaminaRecover)
    //     {
    //         if (Stamina < Const.MaxStamina)
    //         {
    //             Stamina += 1;
    //             hasChanged = true;
    //         }
    //         else if (Stamina < Const.MaxReservedStamina)
    //         {
    //             var rate = ConfigManager.Config.ServerOptions.ReservedStaminaRecoveryRate;
    //             var amount = (timestamp - NextStaminaRecover) / (rate * 1000);
    //             ReservedStamina = (int)Math.Min(ReservedStamina + amount, Const.MaxReservedStamina);
    //             hasChanged = true;
    //         }
    //
    //         if (Stamina >= Const.MaxStamina)
    //         {
    //             NextStaminaRecover = timestamp;
    //         }
    //
    //         NextStaminaRecover += ConfigManager.Config.ServerOptions.StaminaRecoveryRate * 1000;
    //     }
    // }

    public void SendPacket<T>(CmdId cmdId, T data) where T : class
    {
        Session?.Send(cmdId, data);
    }

    public override bool Equals(object? obj)
    {
        return obj is not null && Equals(obj as Account);
    }

    public override int GetHashCode()
    {
        return (int)Id;
    }

    public static bool operator ==(Account? left, Account? right)
    {
        return left is not null && left.Equals(right);
    }

    public static bool operator !=(Account? left, Account? right)
    {
        return !(left == right);
    }

    #region In-game

    public bool IsLoggedIn
    {
        get
        {
            if (Session is null)
                return false;

            return Session.State == NetSessionState.Active;
        }
    }

    public string NickName { get; set; }
    public string Signature { get; set; } = "";
    public Birthday? Birthday { get; set; }
    public int HeadIcon { get; set; }
    public int PhoneTheme { get; set; }
    public int ChatBubble { get; set; }
    public int CurrentBgm { get; set; }
    public Gender Gender { get; set; } = Gender.GENDER_NONE;

    public int Level { get; set; }
    public int Experience { get; set; }
    public int WorldLevel { get; set; }
    private int _stamina = 240;

    public int Stamina
    {
        get => _stamina;
        set
        {
            _stamina = Number.SafeAdd(_stamina, value);
            SendPacket(CmdId.CmdStaminaInfoScNotify, new StaminaInfoScNotify
            {
                NextRecoverTime = NextStaminaRecover / 1000,
                Stamina = (uint)_stamina,
                ReserveStamina = (uint)Math.Floor(ReservedStamina)
            });
        }
    }

    public double ReservedStamina { get; set; } = 2400;
    public long NextStaminaRecover { get; set; }

    // TODO: public Battle Battle { get; set; }
    // TODO: public Scene Scene { get; set; }
    public CurrencyInventory Currency { get; set; }
    public AvatarInventory AvatarInventory { get; set; }
    public UnlockInfo Unlocks { get; set; }
    public Inventory Inventory { get; set; }
    public Mailbox Mailbox { get; set; }
    public ChatManager PrivateChat { get; set; }
    public LineupManager LineupManager { get; set; }
    public GachaInfo Gacha { get; set; }
    public NetSession? Session { get; set; }

    #endregion
}

// ReSharper disable InconsistentNaming
public enum Gender
{
    GENDER_NONE = 0,
    GENDER_MAN = 1,
    GENDER_WOMAN = 2
}
// ReSharper restore InconsistentNaming

public class Birthday(int month, int day)
{
    public int Month { get; set; } = month;
    public int Day { get; set; } = day;
}

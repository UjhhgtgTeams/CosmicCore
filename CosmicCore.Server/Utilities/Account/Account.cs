using CosmicCore.Server.Utilities.Config;
using Serilog;

namespace CosmicCore.Server.Utilities.Account;

internal class Account
{
    public static Account ConsoleAccount = new(0, "Console", "") { Permissions = ["*"] };

    public long Id { get; }
    public string UserName { get; }
    public string Password { get; }
    public string EmailAddress => UserName + "@" + Const.Name.ToLower() + ".com";
    public string ComboToken { get; }
    public string DispatchToken { get; }
    private HashSet<string> Permissions { get; init; } = [];

    public Account(long id, string username, string password)
    {
        Id = id;
        UserName = username;
        Password = password;
        ComboToken = Cryptography.MiHoYoEncryption.GetSessionKey(Id);
        DispatchToken = Cryptography.MiHoYoEncryption.GetSessionKey(Id);
        Log.Debug("Initiated a new Account class with id {0}, username {1} and password {2}", id, username, password);
    }

    public bool HasPermission(string permission)
    {
        Log.Debug("Running permission check for permission {0} and account {1}/{2}", permission, Id, UserName);
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

    public static bool HasPermissionWildcard(string wildcard, string[] permissionParts)
    {
        var wildcardParts = wildcard.Split("\\.").ToList();
        if (permissionParts.Length < wildcardParts.Count) return false;

        foreach (var wildcardPart in wildcardParts)
            switch (wildcardPart)
            {
                case "**":
                    return true;

                case "*":
                    if (wildcardParts.IndexOf(wildcardPart) >= permissionParts.Length - 1) return true;
                    break;

                default:
                    if (wildcardPart != permissionParts[wildcardParts.IndexOf(wildcardPart)]) return false;
                    break;
            }

        return wildcardParts.Count == permissionParts.Length;
    }
}

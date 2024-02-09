namespace CosmicCore.Server.Utilities.Config;

public sealed class Config
{
    public DispatchServerConfig DispatchServer = new("0.0.0.0", 443);
    public GateServerConfig GateServer = new("0.0.0.0", 23301);

    public ServerOptions ServerOptions = new();
    public DownloadData DownloadData = new();

    public StringPath ResourceDirPath = "./resources";
}

public class ServerConfig(string address, int port)
{
    public string Address { get; } = address;
    public int Port { get; } = port;
}

public class DispatchServerConfig(string address, int port) : ServerConfig(address, port)
{
    public bool UseSsl { get; } = false;
    public StringPath SslCertPath { get; } = "./certificate.cer";
    public string SslCertPassword = "12345678";
    public RegionConfig Region { get; } = new();

    public string DisplayAddress => (UseSsl ? "https" : "http") + "://" + Address + ":" + Port;
}

public class RegionConfig
{
    public string Name { get; } = Const.Name;
    public int EnvType { get; } = 2;
    public string DispatchUrl { get; } = "http://dispatch.starrails.com/query_gateway";

    public RegionEntry ToProto()
    {
        return new RegionEntry
        {
            Name = Name,
            DisplayName = Name,
            Title = Name,
            EnvType = EnvType.ToString(),
            DispatchUrl = DispatchUrl
        };
    }
}

public class GateServerConfig(string address, int port) : ServerConfig(address, port)
{
    public string Id { get; } = Const.Name.ToLower() + "_dev";
    public string Name { get; } = Const.Name;
    public string Description { get; } = "A " + Const.Name + " server";
}

public class ServerProfile
{
    public string Name { get; } = "Server";
    public string Signature { get; } = "Type /help for a list of commands";
    public int Level { get; } = 1;
    public int HeadIcon { get; } = 201001;
    public int ChatBubbleId { get; } = 0;
    public int DisplayedAvatarId { get; } = 1001;
    public int DisplayedAvatarLevel { get; } = 1;
}

public class ServerOptions
{
    public bool AutoCreateAccount { get; } = true;
    public int MaxSceneEntityCount { get; } = 500;
    public int MaxCustomRelicLevel { get; } = 15;
    public bool UnlockAllChallenges { get; } = true;
    public bool CostStamina { get; } = true;
    public int StaminaRecoveryRate { get; } = 5 * 60;
    public int ReservedStaminaRecoveryRate { get; } = 18 * 60;
    public int StartingTrailblazerLevel { get; } = 1;
    public bool AutoIncreaseWorldLevel { get; } = true;
    public string? Language { get; } = null;
    public IEnumerable<string> DefaultPermissions { get; } = ["*"];
    public ServerProfile ServerFriendInfo { get; } = new();
}

public class DownloadData
{
    public string? AssetBundleUrl { get; set; } = null;
    public string? ExResourceUrl { get; set; } = null;
    public string? LuaUrl { get; set; } = null;
    // ReSharper disable once InconsistentNaming
    public string? IFixUrl { get; set; } = null;
}

public class LogOptions
{
    public StringPath File { get; } = "./" + Const.Name.ToLower() + ".log";
}

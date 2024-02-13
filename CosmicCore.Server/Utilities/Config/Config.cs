using CosmicCore.Protos;
using Newtonsoft.Json;

namespace CosmicCore.Server.Utilities.Config;

public sealed class Config
{
    public DispatchServerConfig DispatchServer { get; set; }= new("0.0.0.0", 443);
    public GateServerConfig GateServer { get; set; } = new("127.0.0.1", 23301);

    public ServerOptions ServerOptions { get; set; } = new();
    public DownloadData DownloadData { get; set; } = new();

    public StringPath ResourceDirPath { get; set; } = "./resources";
}

public class ServerConfig(string address, int port)
{
    public string Address { get; set; } = address;
    public int Port { get; set; } = port;
}

public class DispatchServerConfig(string address, int port) : ServerConfig(address, port)
{
    public bool UseSsl { get; set; } = false;
    public StringPath SslCertPath { get; set; } = "./certificate.cer";
    public string SslCertPassword { get; set; } = "12345678";
    public RegionConfig Region { get; set; } = new();
    [JsonIgnore] public string DisplayAddress => (UseSsl ? "https" : "http") + "://" + Address + ':' + Port;
}

public class RegionConfig
{
    public string Name { get; set; } = Const.Name;
    public int EnvType { get; set; } = 2;
    public string DispatchUrl { get; set; } = "http://dispatch.starrails.com/query_gateway";

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
    public string Id { get; set; } = Const.Name.ToLower() + "_dev";
    public string Name { get; set; } = Const.Name;
    public string Description { get; set; } = "A " + Const.Name + " server";
    [JsonIgnore] public string DisplayAddress => Address + ':' + Port;
}

public class ServerProfile
{
    public string Name { get; set; } = "Server";
    public string Signature { get; set; } = "Type /help for a list of commands";
    public int Level { get; set; } = 1;
    public int HeadIcon { get; set; } = 201001;
    public int ChatBubbleId { get; set; } = 0;
    public int DisplayedAvatarId { get; set; } = 1001; // TODO: change default
    public int DisplayedAvatarLevel { get; set; } = 1;
}

public class ServerOptions
{
    public bool AutoCreateAccount { get; set; } = true;
    public int MaxSceneEntityCount { get; set; } = 500;
    public int MaxCustomRelicLevel { get; set; } = 15;
    public bool UnlockAllChallenges { get; set; } = true;
    public bool CostStamina { get; set; } = true;
    public int StaminaRecoveryRate { get; set; } = 5 * 60;
    public int ReservedStaminaRecoveryRate { get; set; } = 18 * 60;
    public int StartingTrailblazerLevel { get; set; } = 1;
    public bool AutoIncreaseWorldLevel { get; set; } = true;
    public string? Language { get; set; } = null;
    public IEnumerable<string> DefaultPermissions { get; set; } = [];
    public ServerProfile ServerFriendInfo { get; set; } = new();
}

public class DownloadData
{
    public string? AssetBundleUrl { get; set; } = null;
    public string? ExResourceUrl { get; set; } = null;
    public string? LuaUrl { get; set; } = null;
    // ReSharper disable once InconsistentNaming
    public string? IFixUrl { get; set; } = null;
}

using CosmicCore.Protos;
using Newtonsoft.Json;

namespace CosmicCore.Server.Utilities.Account;

public abstract class AccountManager
{
    [JsonIgnore] internal long OwnerId { get; set; }
    [JsonIgnore] public Account Owner {
        get => Program.AccountDatabase[OwnerId];
        set => OwnerId = value.Id;
    }

    /// <summary>
    /// Sets the owner.
    /// </summary>
    /// <param name="owner">The owner of inherited object. A null value indicates that the owner would be set delayed.</param>
    public AccountManager(Account? owner)
    {
        if (owner is not null)
            Owner = owner;
    }

    public void SendPacket<T>(CmdId cmdId, T data) where T : class
    {
        Owner.Session?.Send(cmdId, data);
    }

    // [JsonIgnore]
    // public NetSession Session
}

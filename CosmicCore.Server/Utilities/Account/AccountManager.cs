using CosmicCore.Protos;

namespace CosmicCore.Server.Utilities.Account;

public abstract class AccountManager
{
    public AccountManager(Account owner)
    {
        Owner = owner;
    }

    internal long OwnerId { get; set; }

    public Account Owner
    {
        get => OwnerId == Const.ServerConsoleId ? Account.Console : Program.AccountDatabase[OwnerId];
        set => OwnerId = value.Id;
    }

    public void SendPacket<T>(CmdId cmdId, T data) where T : class
    {
        Owner.Session?.Send(cmdId, data);
    }

    //
    // public NetSession Session
}

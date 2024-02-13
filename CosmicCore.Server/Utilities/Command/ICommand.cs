namespace CosmicCore.Server.Utilities.Command;

public abstract class ICommand
{
    public abstract Dictionary<int, string> ReturnCodeMap { get; }
    public abstract int OnExecute(string args, Account.Account executor);
}

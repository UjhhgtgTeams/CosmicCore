namespace CosmicCore.Server.Utilities.Command;

public interface ICommand
{
    public Dictionary<int, string> ReturnCodeMap { get; }
    public int OnExecute(string args, Account.Account executor);
}

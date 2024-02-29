namespace CosmicCore.Server.Utilities.Command.Commands;

[Command(Names = ["db", "database"],
    Description = "Manages server account database.",
    Usage = "save",
    RequiredPermissions = ["admin.database"])]
public class DatabaseCommand : ICommand
{
    public Dictionary<int, string> ReturnCodeMap { get; } = [];

    public int OnExecute(string args, Account.Account executor)
    {
        var arguments = CommandUtilities.SplitArgs(args).ToArray();

        if (arguments[0] == "save")
        {
            Program.AccountDatabase.SaveToFile("./accounts.db");
            return 0;
        }

        return 1;
    }
}

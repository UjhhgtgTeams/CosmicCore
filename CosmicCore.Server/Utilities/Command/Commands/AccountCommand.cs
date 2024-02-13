namespace CosmicCore.Server.Utilities.Command.Commands;

[Command(Names = ["acc", "account"],
    Description = "Manages server accounts.",
    Usage = "create|delete <id> (<username>) (<password>)",
    RequiredPermissions = ["admin.account.create", "admin.account.delete"])]
public class AccountCommand : ICommand
{
    public override Dictionary<int, string> ReturnCodeMap { get; } = new()
    {
        { 100, "Account not found!" },
        { 101, "Account already exists!" }
    };

    public override int OnExecute(string args, Account.Account executor)
    {
        var arguments = CommandUtilities.SplitArgs(args).ToArray();

        if (arguments[1] == "create")
        {
            var id = Convert.ToInt32(arguments[2]);
            var username = (arguments.GetValue(3) ?? "User").ToString() + id;
            var password = (arguments.GetValue(4) ?? "").ToString();

            if (id <= Program.AccountDatabase.NextId)
                return 1;

            if (Program.AccountDatabase.ContainsAccount(id))
                return 101;

            Program.AccountDatabase.AddAccount(new Account.Account(id, username, password));
            return 0;
        }

        if (arguments[1] == "delete")
        {
            var id = Convert.ToInt32(arguments[2]);
            if (Program.AccountDatabase.ContainsAccount(id))
            {
                Program.AccountDatabase[id].Session?.Disconnect();
                Program.AccountDatabase.DeleteAccount(id);
                return 0;
            }
            else
            {
                return 100;
            }
        }

        return 1;
    }
}

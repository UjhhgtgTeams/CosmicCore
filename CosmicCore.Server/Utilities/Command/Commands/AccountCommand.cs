namespace CosmicCore.Server.Utilities.Command.Commands;

internal class AccountCommand : ICommand
{
    public override string[] Names { get; } = [];
    public override string Description { get; } = "Manages server accounts.";
    public override string Usage { get; } = "/account create|delete <id> (<username>) (<password>)";
    public override string[] RequiredPermissions { get; } = ["admin.account"];

    public override Dictionary<int, string?> ReturnCodeMap { get; } = new()
    {
        { 100, "Account not found!" },
        { 101, "Account already exists! " }
    };

    /// <summary>
    /// Executes the command.
    /// </summary>
    /// <param name="args">Usage: /account create|delete <id> (<username>) (<password>)</param>
    /// <returns></returns>
    public override int Execute(string args)
    {
        var arguments = CommandUtils.SplitArgs(args).ToArray();

        if (arguments[1] == "create")
        {
            var id = Convert.ToInt32(arguments[2]);
            var username = (arguments.GetValue(3) ?? "User").ToString() + id;
            var password = (arguments.GetValue(4) ?? "").ToString();
            if (Program.AccountDatabase.ContainsAccount(id))
            {
                return 101;
            }
            else
            {
                Program.AccountDatabase.AddAccount(new Account.Account(id, username, password));
                return 0;
            }
        }
        else if (arguments[1] == "delete")
        {
            var id = Convert.ToInt32(arguments[2]);
            if (Program.AccountDatabase.ContainsAccount(id))
            {
                Program.AccountDatabase.DeleteAccount(id);
                return 0;
            }
            else
            {
                return 100;
            }
        }
        else
        {
            return 1;
        }
    }
}

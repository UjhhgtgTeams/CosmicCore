namespace CosmicCore.Server.Utilities.Command;

public abstract class ICommand
{
    public abstract string[] Names { get; }
    public abstract string Description { get; }
    public abstract string? Usage { get; }
    public abstract string[] RequiredPermissions { get; }
    public abstract Dictionary<int, string?> ReturnCodeMap { get; }
    public abstract int Execute(string args);

    internal int OnExecute(string args, Account.Account executor)
    {
        return IsValid(args, executor) ? Execute(args) : 1;
    }

    private bool IsValid(string args, Account.Account executor)
    {
        // permission check
        var containsAllPerms = true;
        foreach (var requiredPerm in RequiredPermissions)
        {
            if (!executor.HasPermission(requiredPerm))
            {
                containsAllPerms = false;
                break;
            }
        }
        if (!containsAllPerms) return false;

        // TODO: usage check
        // if (Usage != null)
        // {
        //     var pattern = Regex.Escape(Usage)
        //         .Replace("<", @"(?<")
        //         .Replace(">", @">[\w\s]+)")
        //         .Replace("|", "|")
        //         .Replace("(", @"\(")
        //         .Replace(")", @"\)?");
        //
        //     return new Regex(pattern).IsMatch(args);
        // }
        return true;
    }
}

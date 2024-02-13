using CosmicCore.Protos;
using CosmicCore.Server.Gate.Network;

namespace CosmicCore.Server.Utilities.Command.Commands;

[Command(Names = ["kick"],
    Description = "Kicks an account if online.",
    Usage = "<@account>",
    RequiredPermissions = ["admin.account.kick"])]
public class KickCommand : ICommand
{
    public override Dictionary<int, string> ReturnCodeMap { get; } = new()
    {
        { 100, "Account not found!" }
    };

    public override int OnExecute(string args, Account.Account executor)
    {
        var arguments = CommandUtilities.SplitArgs(args).ToArray();
        var target = CommandUtilities.ParseAccountSelector(arguments[0]);

        if (target is not null)
        {
            // TODO: find a better kick method since i found PlayerKickOutScNotify in cmd ids
            target.Session?.Disconnect();
            if (target.Session is not null) target.Session.State = NetSessionState.WaitingForToken;
            return 0;
        }

        return 100;
    }
}

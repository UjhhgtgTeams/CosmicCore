using CosmicCore.Server.Gate.Manager.Handlers;
using Serilog;

namespace CosmicCore.Server.Utilities.Command.Commands;

[Command(Names = ["rf", "refill"],
    Description = "Refills the player's hp/sp/mp.",
    Usage = "hp|sp|mp",
    RequiredPermissions = [])]
public class RefillCommand : ICommand
{
    public override Dictionary<int, string> ReturnCodeMap { get; } = [];

    public override int OnExecute(string args)
    {
        var arguments = args.Split(' ').ToList();
        arguments.RemoveAt(0);

        if (PlayerReqGroup.PlayerSession is null)
        {
            Log.Error("Cannot refill hp/sp/mp due to player offline.");
            return 1;
        }

        switch (arguments[0])
        {
            case "hp":
            case "sp":
                Log.Error("Refilling hp/sp is currently unsupported!");
                break;

            case "mp":
                LineupReqGroup.SyncLineup(PlayerReqGroup.PlayerSession);
                Log.Information("Refilled mp for lineup.");
                break;
        }

        return 1;
    }
}

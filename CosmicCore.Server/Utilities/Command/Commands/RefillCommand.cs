namespace CosmicCore.Server.Utilities.Command.Commands;

[Command(Names = ["rf", "refill"],
    Description = "Refills hp, sp and mp.",
    Usage = "hp|sp|mp|all", // sp: energy; mp: skill point
    RequiredPermissions = ["player.refill"])]
public class RefillCommand : ICommand
{
    public override Dictionary<int, string> ReturnCodeMap { get; } = [];

    public override int OnExecute(string args, Account.Account executor)
    {
        var arguments = CommandUtilities.SplitArgs(args).ToArray();

        if (arguments[0] == "hp")
        {
            foreach (var avatarId in executor.LineupManager.CurrentLineup.Avatars)
            {
                var avatar = executor.AvatarInventory.Avatars.TryGetValue(avatarId);
                if (avatar != null) avatar.CurrentHp = 10000;
            }
            executor.LineupManager.CurrentLineup.SyncLineup();
            return 0;
        }

        if (arguments[0] == "sp")
        {
            foreach (var avatarId in executor.LineupManager.CurrentLineup.Avatars)
            {
                var avatar = executor.AvatarInventory.Avatars.TryGetValue(avatarId);
                if (avatar != null) avatar.CurrentSp = 10000;
            }

            executor.LineupManager.CurrentLineup.SyncLineup();
            return 0;
        }

        if (arguments[0] == "mp")
        {
            executor.LineupManager.Mp = Const.MaxMp;
            return 0;
        }

        return 1;
    }
}

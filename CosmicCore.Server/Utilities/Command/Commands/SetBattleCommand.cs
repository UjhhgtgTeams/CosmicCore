using CosmicCore.Server.Gate.Manager.Handlers;

namespace CosmicCore.Server.Utilities.Command.Commands;

[Command(Names = ["btl", "setbattle"],
    Description = "Sets in-battle properties.",
    Usage = "avatar|weapon|arank|wrank",
    RequiredPermissions = [])]
public class SetBattleCommand : ICommand
{
    public override Dictionary<int, string> ReturnCodeMap { get; } = [];

    public override int OnExecute(string args)
    {
        var arguments = args.Split(' ').ToList();
        var operation = args.Split(' ')[0];
        arguments.RemoveAt(0);

        if (operation == "avatar")
        {
            for (var index = 0; index < 4; index++)
            {
                LineupReqGroup.UpdateAvatar(index, Convert.ToInt32(arguments[index]));
            }

            return 0;
        }

        if (operation == "weapon")
        {
            for (var index = 0; index < 4; index++)
            {
                BattleReqGroup.Avatars[index].Weapon.Id = Convert.ToInt32(arguments[index]);
            }

            return 0;
        }

        if (operation == "arank")
        {
            foreach (var avatar in BattleReqGroup.Avatars)
            {
                avatar.Rank = Convert.ToInt32(arguments[0]);
            }

            return 0;
        }

        if (operation == "wrank")
        {
            foreach (var avatar in BattleReqGroup.Avatars)
            {
                avatar.Weapon.Id = Convert.ToInt32(arguments[0]);
            }

            return 0;
        }

        // if (operation == "monsters")
        // {
        //     BattleReqGroup.Monsters = ParseMonsters(arguments[0]);
        //     BattleReqGroup.MonsterLevels = ParseMonsterLevels(arguments[1]);
        //     return 0;
        // }

        return 1;
    }

    // private static Dictionary<uint, List<uint>> ParseMonsters(string rawData)
    // {
    //     var monsters = new Dictionary<uint, List<uint>>();
    //     var regex = MonstersRegex();
    //     var matches = regex.Matches(rawData);
    //
    //     foreach (Match match in matches)
    //     {
    //         var key = uint.Parse(match.Groups[1].Value);
    //         var valuesStr = match.Groups[2].Value;
    //         var values = new List<uint>(Array.ConvertAll(valuesStr.Split(','), uint.Parse));
    //
    //         monsters.Add(key, values);
    //     }
    //
    //     return monsters;
    // }
    //
    // private static Dictionary<uint, uint> ParseMonsterLevels(string rawData)
    // {
    //     var levels = new Dictionary<uint, uint>();
    //     var parts = rawData.Split('|').Select(str => str.Trim('{', '}').Split(','));
    //
    //     foreach (var part in parts)
    //     {
    //         if (part.Length == 2 && uint.TryParse(part[0], out var key) && uint.TryParse(part[1], out var value))
    //         {
    //             levels.Add(key, value);
    //         }
    //     }
    //
    //     return levels;
    // }
    //
    // [GeneratedRegex(@"^\{(\d+),\[(\d+(?:,\d+)*)\]\}$")]
    // private static partial Regex MonstersRegex();
}

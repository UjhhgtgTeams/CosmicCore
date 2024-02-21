using System.Text.RegularExpressions;
using CosmicCore.Server.Gate.Manager.Handlers;

namespace CosmicCore.Server.Utilities.Command.Commands;

[Command(Names = ["btl", "setbattle"],
    Description = "Sets in-battle properties.",
    Usage = "avatar|weapon|arank|wrank",
    RequiredPermissions = [])]
public partial class SetBattleCommand : ICommand
{
    public override Dictionary<int, string> ReturnCodeMap { get; } = [];

    public override int OnExecute(string args)
    {
        var arguments = args.Split(' ').ToList();
        var operation = args.Split(' ')[0];
        arguments.RemoveAt(0);

        if (operation == "avatar")
        {
            var avatars = arguments.Select(avt => Convert.ToUInt32(avt)).ToList();
            BattleReqGroup.Avatar1 = avatars[0];
            BattleReqGroup.Avatar1 = avatars[1];
            BattleReqGroup.Avatar1 = avatars[2];
            BattleReqGroup.Avatar1 = avatars[3];
            return 0;
        }

        if (operation == "weapon")
        {
            var weapons = arguments.Select(avt => Convert.ToUInt32(avt)).ToList();
            BattleReqGroup.Weapon1 = weapons[0];
            BattleReqGroup.Weapon1 = weapons[1];
            BattleReqGroup.Weapon1 = weapons[2];
            BattleReqGroup.Weapon1 = weapons[3];
            return 0;
        }

        if (operation == "arank")
        {
            BattleReqGroup.AvatarRank = Convert.ToUInt32(arguments[0]);
            return 0;
        }

        if (operation == "wrank")
        {
            BattleReqGroup.WeaponRank = Convert.ToUInt32(arguments[0]);
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

    private static Dictionary<uint, List<uint>> ParseMonsters(string rawData)
    {
        var monsters = new Dictionary<uint, List<uint>>();
        var regex = MonstersRegex();
        var matches = regex.Matches(rawData);

        foreach (Match match in matches)
        {
            var key = uint.Parse(match.Groups[1].Value);
            var valuesStr = match.Groups[2].Value;
            var values = new List<uint>(Array.ConvertAll(valuesStr.Split(','), uint.Parse));

            monsters.Add(key, values);
        }

        return monsters;
    }

    private static Dictionary<uint, uint> ParseMonsterLevels(string rawData)
    {
        var levels = new Dictionary<uint, uint>();
        var parts = rawData.Split('|').Select(str => str.Trim('{', '}').Split(','));

        foreach (var part in parts)
        {
            if (part.Length == 2 && uint.TryParse(part[0], out var key) && uint.TryParse(part[1], out uint value))
            {
                levels.Add(key, value);
            }
        }

        return levels;
    }

    [GeneratedRegex(@"^\{(\d+),\[(\d+(?:,\d+)*)\]\}$")]
    private static partial Regex MonstersRegex();
}

using CosmicCore.Server.Utilities.Command;
using CosmicCore.Server.Utilities.Resource;
using Serilog;

namespace CosmicCore.Server.Utilities.Handbook;

public static class HandbookGenerator
{
    public static void Generate(StringPath path)
    {
        Log.Information("Generating server handbook at {Path}...", path);

        using var writer = new StreamWriter(path);

        writer.WriteLine($"# {Const.Name} Handbook for game version {Const.GameVersion}");
        writer.WriteLine($"# Generated on {DateTimeOffset.Now:yyyy-MM-dd HH:mm:ss}");
        writer.WriteLine();

        writer.WriteLine("# Commands");
        foreach (var command in CommandManager.Commands)
        {
            writer.WriteLine($"{command.Usage} - {command.Description}");
        }
        writer.WriteLine();

        writer.WriteLine("# Avatars");
        foreach (var avatar in ResourceManager.AvatarExcels)
        {
            writer.WriteLine($"{avatar.Id} : {ResourceManager.TextMap.GetValueOrDefault(avatar.Id, "null")}");
        }
        writer.WriteLine();

        writer.WriteLine("# Items");
        foreach (var item in ResourceManager.ItemExcels)
        {
            writer.WriteLine($"{item.Id} : {ResourceManager.TextMap.GetValueOrDefault(item.Id, "null")}");
        }
        writer.WriteLine();

        writer.WriteLine("# Props (Spawnable)");
        foreach (var prop in ResourceManager.PropExcels)
        {
            writer.WriteLine($"{prop.Id} : {ResourceManager.TextMap.GetValueOrDefault(prop.PropName, "null")}");
        }
        writer.WriteLine();

        writer.WriteLine("# NPC Monsters (Spawnable)");
        foreach (var npcMonster in ResourceManager.NpcMonsterExcels)
        {
            writer.WriteLine(
                $"{npcMonster.Id} : {ResourceManager.TextMap.GetValueOrDefault(npcMonster.NPCName, "null")}");
        }
        writer.WriteLine();

        writer.WriteLine("# Battle Stages");
        foreach (var stage in ResourceManager.StageExcels)
        {
            writer.WriteLine(
                $"{stage.Id} : [Level {stage.Level}] {ResourceManager.TextMap.GetValueOrDefault(stage.StageName, "null")}");
        }
        writer.WriteLine();

        writer.WriteLine("# Mazes");
        foreach (var mazePlane in ResourceManager.MazePlaneExcels)
        {
            writer.WriteLine(
                $"{mazePlane.Id} : [{mazePlane.PlaneType}] {ResourceManager.TextMap.GetValueOrDefault(mazePlane.PlaneName, "null")}");
        }
        writer.WriteLine();

        Log.Information("Handbook generated");
    }
}

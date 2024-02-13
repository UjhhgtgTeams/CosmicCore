using CosmicCore.Server.Utilities.Command;
using CosmicCore.Server.Utilities.Locale;
using CosmicCore.Server.Utilities.Resource;
using CosmicCore.Server.Utilities.Resource.Resources;
using Serilog;

namespace CosmicCore.Server.Utilities.Handbook;

public static class HandbookGenerator
{
    public static void Generate(StringPath path)
    {
        Log.Information("Generating server handbook at {Path}...", path);

        using var writer = new StreamWriter(path);

        writer.WriteLine($"# {Const.Name} Handbook");
        writer.WriteLine($"# Generate Time: {DateTimeOffset.Now:yyyy-MM-dd HH:mm:ss}");
        writer.WriteLine($"# Game version: {Const.GameVersion}");
        writer.WriteLine($"# Text map locale: {LocaleManager.CurrentLocale}");
        writer.WriteLine();

        writer.WriteLine("# Commands");
        foreach (var attr in CommandManager.Commands.Select(CommandManager.GetCommandAttributeOf))
        {
            writer.WriteLine($"/{string.Join('|', attr.Names)} {attr.Usage} - {attr.Description}");
        }
        writer.WriteLine();

        writer.WriteLine("# Avatars");
        foreach (var avatar in ResourceManager.AvatarExcels)
        {
            writer.WriteLine($"{avatar.Id} : [Element {ResourceManager.GetTextMapEntry(avatar.DamageType.TextMapHash())} | Path {ResourceManager.GetTextMapEntry(avatar.AvatarBaseType.TextMapHash())}] {ResourceManager.GetTextMapEntry(avatar.AvatarName)}");
        }
        writer.WriteLine();

        writer.WriteLine("# Items");
        foreach (var item in ResourceManager.ItemExcels)
        {
            writer.WriteLine($"{item.Id} : [Rarity {item.Rarity.ToString()}] {ResourceManager.GetTextMapEntry(item.ItemName)}");
        }
        writer.WriteLine();

        writer.WriteLine("# Props (Spawnable)");
        foreach (var prop in ResourceManager.PropExcels)
        {
            writer.WriteLine($"{prop.Id} : [{prop.PropType.ToString()}] {ResourceManager.GetTextMapEntry(prop.PropName)}");
        }
        writer.WriteLine();

        writer.WriteLine("# NPC Monsters (Spawnable)");
        foreach (var npcMonster in ResourceManager.NpcMonsterExcels)
        {
            writer.WriteLine(
                $"{npcMonster.Id} : {ResourceManager.GetTextMapEntry(npcMonster.NpcName)}");
        }
        writer.WriteLine();

        writer.WriteLine("# Battle Stages");
        foreach (var stage in ResourceManager.StageExcels)
        {
            writer.WriteLine(
                $"{stage.Id} : [{stage.StageType.ToString()} | Level {stage.Level}] {ResourceManager.GetTextMapEntry(stage.StageName)}");
        }
        writer.WriteLine();

        writer.WriteLine("# Mazes");
        foreach (var mazePlane in ResourceManager.MazePlaneExcels)
        {
            writer.WriteLine(
                $"{mazePlane.Id} : [{mazePlane.PlaneType.ToString()}] {ResourceManager.GetTextMapEntry(mazePlane.PlaneName)}");
        }
        writer.WriteLine();

        Log.Information("Handbook generated");
    }
}

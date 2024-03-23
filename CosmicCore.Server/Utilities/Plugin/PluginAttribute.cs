namespace CosmicCore.Server.Utilities.Plugin;

[AttributeUsage(AttributeTargets.Class)]
public class PluginAttribute : Attribute
{
    public required string Name { get; init; }
    public required string Description { get; init; }
    public string[] Dependencies { get; init; } = [];
}

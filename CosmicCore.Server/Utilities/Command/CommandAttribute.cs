namespace CosmicCore.Server.Utilities.Command;

[AttributeUsage(AttributeTargets.Class)]
public class CommandAttribute : Attribute
{
    public required string[] Names { get; init; }
    public required string Description { get; init; }
    public required string Usage { get; init; }
    public required string[] RequiredPermissions { get; init; }
}

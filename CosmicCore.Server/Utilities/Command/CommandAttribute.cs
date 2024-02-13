namespace CosmicCore.Server.Utilities.Command;

[AttributeUsage(AttributeTargets.Class)]
public class CommandAttribute : Attribute
{
    public string[] Names { get; set; } = ["should_not_happen"];
    public string Description { get; set; } = "Should not happen.";
    public string? Usage { get; set; } = null;
    public string[] RequiredPermissions { get; set; } = ["should.not.happen"];
}

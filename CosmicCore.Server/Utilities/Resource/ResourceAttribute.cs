namespace CosmicCore.Server.Utilities.Resource;

[AttributeUsage(AttributeTargets.Class)]
public class ResourceAttribute : Attribute
{
    public string[] FileNames { get; set; } = [];
    public ResourceLoadPriority LoadPriority { get; set; } = ResourceLoadPriority.Normal;
}

namespace CosmicCore.Server.Utilities.Resource;

[AttributeUsage(AttributeTargets.Class)]
internal class ResourceAttribute : Attribute
{
    public string[] FileNames { get; set; } = [];
    public ResourceLoadPriority LoadPriority { get; set; } = ResourceLoadPriority.Normal;
}

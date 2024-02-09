namespace CosmicCore.Server.Utilities.Resource;

public abstract class IResource
{
    public abstract int Id { get; }
    public abstract void OnLoad();
}

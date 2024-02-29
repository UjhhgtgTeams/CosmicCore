namespace CosmicCore.Server.Utilities.Resource;

public interface IResource
{
    public int Id { get; }
    public void OnLoad();
}

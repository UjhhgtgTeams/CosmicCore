namespace CosmicCore.Server.Utilities.External;

public interface IExternalTool : IDisposable
{
    public bool Ready { get; }
    public new void Dispose();
}

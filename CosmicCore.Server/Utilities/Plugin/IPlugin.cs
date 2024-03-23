using System.Reflection;

namespace CosmicCore.Server.Utilities.Plugin;

public abstract class IPlugin
{
    public required Assembly Assembly { get; set; }

    public static int ApiVersion => 1;
    public Stream? GetResource(string name) => Assembly.GetManifestResourceStream(name);

    #region Plugin events called by server

    public abstract void OnLoad();
    public abstract void OnEnable();
    public abstract void OnDisable();

    #endregion
}

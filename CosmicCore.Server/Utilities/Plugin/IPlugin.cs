using System.Reflection;
using CosmicCore.Server.Utilities.Command;

namespace CosmicCore.Server.Utilities.Plugin;

public abstract class IPlugin
{
    public Assembly Assembly { get; set; }

    public Stream GetResource(string filepath)
    {
        return Assembly.GetManifestResourceStream(filepath) ??
               throw new FileNotFoundException("Requested plugin resource not found");
    }

    public abstract string Name { get; }
    public abstract string Description { get; }
    public static int ApiVersion => 1;
    public abstract string[] Dependencies { get; }
    public abstract ICommand[] Commands { get; }

    #region Plugin events called by server

    public abstract void OnLoad();
    public abstract void OnEnable();
    public abstract void OnDisable();
    //public abstract void OnTick();

    #endregion
}

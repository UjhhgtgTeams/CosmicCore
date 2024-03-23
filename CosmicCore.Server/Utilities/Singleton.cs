namespace CosmicCore.Server.Utilities;

public abstract class Singleton<T> where T : class
{
    // ReSharper disable once InconsistentNaming
    private static readonly Lazy<T> _instance = new(() => (Activator.CreateInstance(typeof(T), true) as T)!);

    public static T Instance => _instance.Value;
}

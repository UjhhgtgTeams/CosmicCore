using System.Diagnostics;

namespace CosmicCore.Server.Utilities;

public static class PerformanceWatcher
{
    private static Stopwatch _stopwatch = new();

    public static void Start()
    {
        _stopwatch.Restart();
    }

    /// <summary>
    /// Stops the stopwatch and return elapsed time.
    /// </summary>
    /// <returns>A TimeSpan object containing time elapsed.</returns>
    public static TimeSpan Stop()
    {
        _stopwatch.Stop();
        return _stopwatch.Elapsed;
    }
}

using Serilog;

namespace CosmicCore.Server.Utilities.Handbook;

public static class HandbookGenerator
{
    public static void Generate(string path)
    {
        Log.Information("Generating server handbook at {Path}...", path);
        Log.Warning("Beta versions do not support handbook generation!");
    }
}

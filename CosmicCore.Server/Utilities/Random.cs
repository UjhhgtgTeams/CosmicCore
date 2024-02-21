namespace CosmicCore.Server.Utilities;

public static class Random
{
    private static readonly System.Random _random = new();

    public static int FromIntRange(int end)
    {
        return _random.Next(0, end + 1);
    }

    public static int FromIntRange(int start, int end)
    {
        return _random.Next(start, end + 1);
    }

    public static T FromList<T>(List<T> enumerable)
    {
        var index = FromIntRange(0, enumerable.Count - 1);
        return enumerable[index];
    }
}

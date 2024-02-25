namespace CosmicCore.Server.Utilities;

public static class RandomUtil
{
    private static readonly Random Random = new();

    public static int FromIntRange(int end)
    {
        return Random.Next(0, end + 1);
    }

    public static int FromIntRange(int start, int end)
    {
        return Random.Next(start, end + 1);
    }

    public static T FromList<T>(List<T> enumerable)
    {
        var index = FromIntRange(0, enumerable.Count - 1);
        return enumerable[index];
    }
}

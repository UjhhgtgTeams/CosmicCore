namespace CosmicCore.Server.Utilities;

public static class ListUtil
{
    public static IEnumerable<int> FromIntRange(int start, int end)
    {
        for (var i = start; i <= end; i++)
        {
            yield return i;
        }
    }

    public static IEnumerable<uint> FromUIntRange(uint start, uint end)
    {
        for (var i = start; i <= end; i++)
        {
            yield return i;
        }
    }
}

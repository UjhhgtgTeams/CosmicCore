namespace CosmicCore.Server.Utilities;

public static class NumberUtils
{
    public static int SafeAdd(int left, int right, long min = 0, long max = int.MaxValue)
    {
        unchecked
        {
            var result = (long)left + (long)right;
            if (result < min)
                return (int)min;
            if (result > max)
                return (int)max;
            return (int)result;
        }
    }

    public static int SafeSubtract(int left, int right, long min = int.MinValue, long max = int.MaxValue)
    {
        unchecked
        {
            var result = (long)left - (long)right;
            if (result < min)
                return (int)min;
            if (result > max)
                return (int)max;
            return (int)result;
        }
    }
}

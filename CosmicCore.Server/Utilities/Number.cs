namespace CosmicCore.Server.Utilities;

public static class Number
{
    public static int SafeAdd(int left, int right)
    {
        return SafeAdd(left, right, 0, int.MaxValue);
    }

    public static int SafeAdd(int left, int right, long min, long max)
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

    public static int SafeSubtract(int left, int right)
    {
        return SafeSubtract(left, right, int.MinValue, int.MaxValue);
    }

    public static int SafeSubtract(int left, int right, long min, long max)
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

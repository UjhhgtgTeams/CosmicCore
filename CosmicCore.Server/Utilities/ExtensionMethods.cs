namespace CosmicCore.Server.Utilities;

public static class ExtensionMethods
{
    public static void RunSync(this Task task)
    {
        task.GetAwaiter().GetResult();
    }

    public static T RunSync<T>(this Task<T> task)
    {
        task.GetAwaiter().GetResult();
        return task.Result;
    }

    /// <summary>
    /// Returns the value according to its key in a dictionary,
    /// or null if key does not exist.
    /// </summary>
    public static TValue? TryGetValue<TKey, TValue>(this Dictionary<TKey, TValue> dict, TKey key) where TKey : notnull
    {
        dict.TryGetValue(key, out var value);
        return value;
    }

    public static T? TryGet<T>(this T[] enumerable, int index) where T : class
    {
        T? value;

        try
        {
            value = enumerable[index];
        }
        catch (IndexOutOfRangeException)
        {
            value = null;
        }

        return value;
    }

    public static void AddRange<TKey, TValue>(this Dictionary<TKey, TValue> left, Dictionary<TKey, TValue> right) where TKey : notnull
    {
        foreach (var pair in right)
        {
            left.Add(pair.Key, pair.Value);
        }
    }

    public static void AddRange<T>(this HashSet<T> left, IEnumerable<T> right)
    {
        foreach (var item in right)
        {
            left.Add(item);
        }
    }

    public static Dictionary<TKey, TValue> ConcatenateRange<TKey, TValue>(this Dictionary<TKey, TValue> left, Dictionary<TKey, TValue> right) where TKey : notnull
    {
        var dict = left.ToDictionary(pair => pair.Key, pair => pair.Value);

        foreach (var pair in right)
        {
            if (!dict.TryAdd(pair.Key, pair.Value))
            {
                dict[pair.Key] = pair.Value;
            }
        }

        return dict;
    }

    public static StringPath ToFullPath(this string other)
    {
        return other;
    }

    public static string ReadAllAsString(this Stream stream)
    {
        return stream.ReadAllAsString(Encoding.UTF8);
    }

    public static string ReadAllAsString(this Stream stream, Encoding encoding)
    {
        using var reader = new StreamReader(stream, encoding);
        return reader.ReadToEnd();
    }
}

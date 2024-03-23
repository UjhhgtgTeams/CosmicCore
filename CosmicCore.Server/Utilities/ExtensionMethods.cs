using System.Diagnostics.Contracts;

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

    [Pure]
    public static byte[] ToBytesFromHex(this string hexString)
    {
        string[] strValues;
        if (hexString.Contains(','))
            strValues = hexString.Split(',');
        else if (hexString.Contains(' '))
            strValues = hexString.Split(' ');
        else if (hexString.Length <= 2)
            strValues = [hexString];
        else
            throw new ArgumentException("Given string does not contain hex values joined with comma or space",
                nameof(hexString));

        List<byte> byteValues = [];
        foreach (var hexValue in strValues)
        {
            var intValue = Convert.ToInt32(hexValue, 16);
            var byteValue = Convert.ToByte(intValue);
            byteValues.Add(byteValue);
        }

        return byteValues.ToArray();
    }

    /// <summary>
    /// Determines whether an IEnumerable contains any element in another IEnumerable.
    /// </summary>
    /// <param name="left">An IEnumerable.</param>
    /// <param name="right">Another IEnumerable.</param>
    /// <returns>A boolean indicating whether any item in right exists in left.</returns>
    [Pure]
    public static bool ContainsAnyInRange<T>(this IEnumerable<T> left, IEnumerable<T> right)
    {
        return left.All(item => !right.Contains(item));
    }

    /// <summary>Joins a sequence of another sequence into one single sequence.</summary>
    /// <param name="source">An IEnumerable of values to project.</param>
    /// <returns>An IEnumerable whose elements are joined.</returns>
    [Pure]
    public static IEnumerable<T> SelectMany<T>(this IEnumerable<IEnumerable<T>>? source)
    {
        ArgumentNullException.ThrowIfNull(source, nameof(source));
        return source.SelectMany(item => item);
    }

    [Pure]
    public static T? TryGet<T>(this T[] enumerable, int index) where T : class
    {
        T? value;

        try
        {
            value = enumerable[index];
        }
        catch (IndexOutOfRangeException)
        {
            return null;
        }

        return value;
    }

    public static void AddRange<T>(this HashSet<T> left, IEnumerable<T> right)
    {
        foreach (var item in right)
        {
            left.Add(item);
        }
    }

    [Pure]
    public static Dictionary<TKey, TValue> JoinRange<TKey, TValue>(this Dictionary<TKey, TValue> left,
        Dictionary<TKey, TValue> right) where TKey : notnull
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

﻿using System.Text;

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

    public static void AddRange<TKey, TValue>(this Dictionary<TKey, TValue> left, Dictionary<TKey, TValue> right) where TKey : notnull
    {
        foreach (var pair in right)
        {
            left.Add(pair.Key, pair.Value);
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

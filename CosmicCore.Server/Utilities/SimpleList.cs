using System.Collections.ObjectModel;

namespace CosmicCore.Server.Utilities;

public class SimpleList<T> : Collection<T>
{
    private T[] _storage = [];

    public SimpleList()
    {

    }

    public SimpleList(IEnumerable<T> other)
    {
        _storage = other.ToArray();
    }

    public SimpleList(T[] other)
    {
        _storage = other;
    }

    public SimpleList(List<T> other)
    {
        _storage = other.ToArray();
    }

    public static SimpleList<T> operator +(SimpleList<T> left, T right)
    {
        return new SimpleList<T>(left._storage.Append(right));
    }

    public static SimpleList<T> operator -(SimpleList<T> left, T right)
    {
        var simpleList = new SimpleList<T>();
        var list = left._storage.ToList();
        list.Remove(right);
        simpleList._storage = list.ToArray();
        return simpleList;
    }

    public static SimpleList<T> operator +(SimpleList<T> left, SimpleList<T> right)
    {
        var simpleList = new SimpleList<T>
        {
            _storage = left._storage
        };
        foreach (var item in right._storage)
        {
            simpleList += item;
        }

        return left;
    }

    public static SimpleList<T> operator -(SimpleList<T> left, SimpleList<T> right)
    {
        var simpleList = new SimpleList<T>
        {
            _storage = left._storage
        };
        foreach (var item in right._storage)
        {
            simpleList += item;
        }

        return left;
    }
}

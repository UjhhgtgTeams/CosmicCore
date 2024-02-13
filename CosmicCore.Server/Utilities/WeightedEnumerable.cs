using System.Collections;

namespace CosmicCore.Server.Utilities;

public class WeightedEnumerable<T> : IEnumerable<T>
{
    private readonly List<(T item, double weight)> _items = [];
    private readonly System.Random _random = new();

    public void Add(T item, double weight)
    {
        if (weight < 0)
            throw new ArgumentException("Weight cannot be negative.", nameof(weight));

        _items.Add((item, weight));
    }

    public IEnumerator<T> GetEnumerator()
    {
        var totalWeight = _items.Sum(i => i.weight);

        double cumulativeWeight = 0;
        foreach (var (item, weight) in _items)
        {
            cumulativeWeight += weight;
            if (_random.NextDouble() < cumulativeWeight / totalWeight)
            {
                yield return item;
                yield break;
            }
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

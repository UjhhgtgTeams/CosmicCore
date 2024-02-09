using System.Reflection;

namespace CosmicCore.Server.Utilities;

/// <summary>
/// Simple class that represents a string containing a full path to file.
/// (Utility used for getting full path of file.)
/// </summary>
/// <param name="path">Path to a file or directory.</param>
public class StringPath
{
    public string Path { get; private set; }

    public StringPath(string path)
    {
        Path = System.IO.Path.GetFullPath(path) == path
            ? path
            : System.IO.Path.GetFullPath(System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? "", path));
    }

    public static implicit operator StringPath(string other)
    {
        return new StringPath(other);
    }

    public static implicit operator string(StringPath other)
    {
        return other.Path;
    }

    public static bool operator ==(StringPath left, StringPath right)
    {
        return left.Path == right.Path;
    }

    public static bool operator !=(StringPath left, StringPath right)
    {
        return !(left == right);
    }

    public override bool Equals(object? obj)
    {
        return (obj as StringPath)!.Path == Path;
    }

    public override int GetHashCode()
    {
        return Path.GetHashCode();
    }

    public override string ToString()
    {
        return Path;
    }
}

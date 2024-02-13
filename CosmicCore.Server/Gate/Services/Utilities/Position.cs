using CosmicCore.Protos;

namespace CosmicCore.Server.Gate.Services.Utils;

public class Position(int x, int y, int z)
{
    public int X { get; } = x;
    public int Y { get; } = y;
    public int Z { get; } = z;

    public static implicit operator Position(Vector other)
    {
        return new Position(other.X, other.Y, other.Z);
    }

    public double Get2dDist(Position pos)
    {
        var x = X - pos.X;
        var z = Z - pos.Z;
        return Math.Sqrt(x * x + z * z);
    }

    public long GetFast2dDist(Position pos)
    {
        long x = X - pos.X;
        long z = Z - pos.Z;
        return x * x + z * z;
    }

    public override string ToString()
    {
        return $"[ {X} , {Y} ]";
    }
}

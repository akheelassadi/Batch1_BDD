using System;

namespace MarsRovers
{
    public class Point
    {
        public Point(int v1, int v2)
        {
            X = v1;
            Y = v2;
        }

        public int X { get; }
        public int Y { get; }

        public override bool Equals(object obj)
        {
            return obj is Point point &&
                   X == point.X &&
                   Y == point.Y;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }
    }
}
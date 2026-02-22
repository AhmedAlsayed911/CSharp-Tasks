using System;
using System.Collections.Generic;
using System.Text;

namespace PointHandler
{
    internal class Point : IComparable, ICloneable
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Z { get; private set; }

        public Point(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Point(int x, int y) : this(x, y, 0)
        {

        }

        public Point(int x) : this(x, 0, 0)
        {

        }

        public override string ToString()
        {
            return $"Point Coordinates :  ({X}, {Y}, {Z})";
        }

        public override bool Equals(object? obj)
        {
            if (obj is not null)
            {
                Point p = (Point)obj;
                return X == p.X && Y == p.Y && Z == p.Z;
            }
            return false;
        }

        public int CompareTo(object? obj)
        {
            if (obj is null || obj is not Point p) return -1;

            int cmp = X.CompareTo(p.X);
            if (cmp != 0) return cmp;

            int cmp2 = Y.CompareTo(p.Y);
            if (cmp2 != 0) return cmp2;

            return Z.CompareTo(p.Z);
        }


        public object Clone()
        {
            return new Point(X, Y, Z);
        }
    }
}

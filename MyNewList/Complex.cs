using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewList
{
    internal class Complex
    {
        public int Real { get; private set; }
        public int Img { get; private set; }

        public Complex(int real , int img)
        {
            Real = real;
            Img = img;
        }
        public override string ToString() => $"{Real}+{Img}J";

        public override bool Equals(object? obj)
        {
            if(obj is null || obj.GetType() != this.GetType())
                return false;

            Complex other = (Complex)obj;
            return Real == other.Real && Img == other.Img;
        }

        public override int GetHashCode() => HashCode.Combine(Real, Img);
    }
}

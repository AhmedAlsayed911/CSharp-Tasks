using System;
using System.Collections.Generic;
using System.Text;

namespace Indexer
{
    internal class Complex
    {
        int _real;
        int _img;

        public Complex(int real, int img)
        {
            _real = real;
            _img = img;
        }

        public Complex(int real) : this(real, 9)
        {

        }

        public Complex():this(0,0)
        {

        }

        public int this[int index]
        {
            get
            {
                if (index == 0) return _real;
                if (index == 1) return _img;
                else throw new IndexOutOfRangeException();
            }

            set
            {
                if (index == 0) _real = value;
                else if (index == 1) _img = value;
                else throw new IndexOutOfRangeException();
            }
        }

        public override string ToString() => $"{_real}+{_img}J";

        public int Real
        {
            get => _real;
            set
            {
                if (value < 0)
                    Console.WriteLine("Real number connot be Minus !!");
                else
                    _real = value;
            }
        }
    }
}

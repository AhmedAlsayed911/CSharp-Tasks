using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MyNewList
{
    internal class MyList<T> : IEnumerable<T>
    {
        T[] _arr;
        int _size;
        int e;

        public MyList()
        {
            _size = 4;
            _arr = new T[_size];
        }
        public MyList(int s)
        {
            _size = s;
            _arr = new T[_size];
        }

        public void Add(T item)
        {
            if (e < _size)
                _arr[e++] = item;
            else
            {
                T[] newArr = new T[_size *= 2];
                for (int i = 0; i < e; i++)
                    newArr[i] = _arr[i];

                _arr = newArr;
                _arr[e++] = item;
            }
        }
        public void Remove(T item)
        {
            for (int i = 0; i < e; i++)
            {
                if (_arr[i].Equals(item))
                {
                    for (int j = i + 1; j < e; j++)
                        _arr[j - 1] = _arr[j];

                    e--;
                    break;
                }
            }
        }

        public void Print()
        {
            for (int i = 0; i < e; i++)
                Console.WriteLine(_arr[i]);
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in _arr)
                yield return item;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public T this[int index]
        {
            get
            {
                if (index < e)
                    return _arr[index];
                else
                    throw new IndexOutOfRangeException();
            }
            set
            {
                if (index < e)
                    _arr[index] = value;
                else
                    throw new IndexOutOfRangeException();
            }
        }
        public T? Find(Func<T, bool> condition)
        {
            foreach (var item in _arr)
                if (condition(item))
                    return item;

            return default;
        }

        public MyList<T> FindAll(Predicate<T> predicate)
        {
            MyList<T> result = new MyList<T>();
            foreach (T item in _arr)
            {
                if (predicate(item))
                    result.Add(item);
            }
            return result;
        }
    }
}

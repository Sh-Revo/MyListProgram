using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyListProgram
{
    public class MyList
    {
        private int[] _array;
        private const int defaultSize = 4;
        private const double Increment = 1.33;
        private int _currentCount;

        private int DefaultNewSize => (int)(_array.Length * Increment);
        public int Count => _currentCount;
        public int Capacity => _array.Length;

        public MyList()
        {
            _array = new int[defaultSize];
        }

        public void Add(int element)
        {
            if (Count == Capacity)
            {
                Resize(DefaultNewSize);
            }

            _array[_currentCount++] = element;
        }

        public void Resize(int newSize)
        {
            int[] newArray = new int[newSize];
            for (int i = 0; i < _array.Length; i++)
            {
                newArray[i] = _array[i]; 
            }

            _array = newArray;
        }

        public void AddFirst(int element)
        {
            AddByIndex(element, 0);
        }

        public void AddByIndex(int element, int ind)
        {
            if (ind > Count)
            {
                throw IndexOutOfRangeException("Index bigger than size array");
            }
            int[] newArray = new int[(int)(_array.Length * 1.33)];
            for (int i = 0; i < ind; i++)
            {
                newArray[i] = _array[i];
            }
            newArray[ind] = element;
            for (int i = ind; i < _array.Length; i++)
            {
                newArray[i + 1] = _array[i];
            }
            _array = newArray;

            ++_currentCount;
        }

        //public void DeleteFromEnd()
        //{

        //}

        //public void DeleteByIndex()
        //{

        //}

        private Exception IndexOutOfRangeException(string v)
        {
            throw new NotImplementedException();
        }
    }
}

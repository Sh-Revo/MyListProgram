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
        private int _currentCount;

        public int Length => _currentCount;
        public int Capacity => _array.Length;

        public int this[int index]
        {
            get
            {
                if (index >= Length || index < 0)
                {
                    throw new ArgumentException();
                }

                return _array[index];
            }
        }

        public MyList()
        {
            _array = new int[defaultSize];
            _currentCount = 0;
        }

        public void AddBack(int element)
        {
            if (Capacity > Length)
            {
                _array[_currentCount] = element;
            }
            else
            {
                int[] newArray = new int[(int)(_array.Length * 1.33)];
                for (int i = 0; i < _array.Length; i++)
                {
                    newArray[i] = _array[i];
                }

                newArray[_currentCount] = element;
                _array = newArray;
            }

            ++_currentCount;
        }

        public void AddFirst(int element)
        {
            AddByIndex(element, 0);
        }

        public void AddByIndex(int element, int ind)
        {
            if (ind > Length)
            {
                throw IndexOutOfRangeException ("Index bigger than size array");
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

        public void DeleteFromEnd()
        {

        }

        private Exception IndexOutOfRangeException(string v)
        {
            throw new NotImplementedException();
        }
    }
}

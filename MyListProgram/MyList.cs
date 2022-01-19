using System;
using System.Collections;
using System.Collections.Generic;

namespace MyListProgram
{
    public class MyList : IList
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

        public void AddFirst(int element)
        {
            AddByIndex(element, 0);
        }

        public void AddByIndex(int element, int ind)
        {
            if (ind > Count || ind < 0)
            {
                throw new ArgumentException("Index bigger than size array or index <0");
            }

            int[] newArray = new int[(int)(_array.Length + 1)];
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
            if (_currentCount == 0)
            {
                throw new ArgumentException("Array is empty");
            }

            --_currentCount;
        }

        public void DeleteFromStart()
        {
            DeleteByIndex(0);
        }

        public void DeleteByIndex(int index)
        {
            if (index > Count || index < 0)
            {
                throw new ArgumentException("Index bigger than size array or index <0");
            }
            if (_currentCount == 0)
            {
                throw new ArgumentException("Array is empty");
            }

            int[] newArray = new int[(int)(_array.Length - 1)];

            for (int i = 0; i < index; i++)
            {
                newArray[i] = _array[i];
            }
            for (int i = index + 1; i < _array.Length; i++)
            {
                newArray[i - 1] = _array[i];
            }
            _array = newArray;
        }

        public void DeleteFromEndNElements(int number)
        {
            if (number > Count)
            {
                throw new ArgumentException("Size bigger than size array");
            }
            if (_currentCount == 0)
            {
                throw new ArgumentException("Array is empty");
            }

            int[] newArray = new int[(int)(_array.Length) - number];

            for (int i = 0; i < _array.Length - number; i++)
            {
                newArray[i] = _array[i];
            }

            _array = newArray;
        }

        public void DeleteFromStartNElements(int number)
        {
            if (number > Count)
            {
                throw new ArgumentException("Size bigger than size array");
            }
            if (_currentCount == 0)
            {
                throw new ArgumentException("Array is empty");
            }

            int[] newArray = new int[(int)(_array.Length) - number];

            for (int i = number; i < _array.Length; i++)
            {
                newArray[i] = _array[i];
            }

            _array = newArray;
        }

        public void DeleteNElementsFromIndex(int number, int index)
        {
            if (number > Count)
            {
                throw new ArgumentException("Size bigger than size array");
            }
            if (index > Count)
            {
                throw new ArgumentException("Index bigger than size array");
            }
            if (_currentCount == 0)
            {
                throw new ArgumentException("Array is empty");
            }

            int[] newArray = new int[(int)(_array.Length) - number];

            for (int i = 0; i < index; i++)
            {
                newArray[i] = _array[i];
            }
            for (int i = number + index; i < _array.Length; i++)
            {
                newArray[i] = _array[i];
            }

            _array = newArray;
        }

        public int GetValueByIndex(int index)
        {
            if (index > Count)
            {
                throw new ArgumentException("Index bigger than size array");
            }
            if (_currentCount == 0)
            {
                throw new ArgumentException("Array is empty");
            }

            int value = _array[index];

            return value;
        }

        public int GetIndexByFirstNumber(int value)
        {
            if (_currentCount == 0)
            {
                throw new ArgumentException("Array is empty");
            }

            int index = 0;

            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] == value)
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        public void ChangeValueByIndex(int value, int index)
        {
            if (index > Count)
            {
                throw new ArgumentException("Index bigger than size array");
            }

            int[] newArray = new int[(int)(_array.Length)];
            for (int i = 0; i < index; i++)
            {
                newArray[i] = _array[i];
            }
            newArray[index] = value;
            for (int i = index + 1; i < _array.Length; i++)
            {
                newArray[i] = _array[i];
            }
            _array = newArray;
        }

        public void Reverse()
        {
            if (_currentCount == 0)
            {
                throw new ArgumentException("Array is empty");
            }

            for (int i = 0; i < _array.Length / 2; i++)
            {
                int tmp = _array[i];
                _array[i] = _array[_array.Length - i - 1];
                _array[_array.Length - i - 1] = tmp;
            }
        }

        public int GetMaxIndex()
        {
            if (_currentCount == 0)
            {
                throw new ArgumentException("Array is empty");
            }

            int maxIndex = 0;

            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] > _array[maxIndex])
                {
                    maxIndex = i;
                }
            }

            return maxIndex;
        }

        public int GetMax()
        {
            return _array[GetMaxIndex()];
        }

        public int GetMinIndex()
        {
            if (_currentCount == 0)
            {
                throw new ArgumentException("Array is empty");
            }

            int minIndex = 0;

            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] < _array[minIndex])
                {
                    minIndex = i;
                }
            }

            return minIndex;
        }

        public int GetMin()
        {
            return _array[GetMinIndex()];
        }

        public void SortByAsc()
        {
            if (_currentCount == 0)
            {
                throw new ArgumentException("Array is empty");
            }

            for (int i = 0; i < _array.Length; i++)
            {
                for (int j = 0; j < _array.Length - 1; j++)
                {
                    if (_array[j] > _array[j + 1])
                    {
                        Swap(ref _array[j], ref _array[j + 1]);
                    }
                }
            }
        }

        public void SortByDesc()
        {
            if (_currentCount == 0)
            {
                throw new ArgumentException("Array is empty");
            }

            for (int i = 0; i < _array.Length; i++)
            {
                for (int j = 0; j < _array.Length - 1; j++)
                {
                    if (_array[j] < _array[j + 1])
                    {
                        Swap(ref _array[j], ref _array[j + 1]);
                    }
                }
            }
        }

        public void DeleteByFirstNumber(int value)
        {
            if (_currentCount == 0)
            {
                throw new ArgumentException("Array is empty");
            }

            int index;
            int[] newArray = new int[(int)(_array.Length) - 1];

            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] == value)
                {
                    index = i;
                    for (int j = 0; j < index; j++)
                    {
                        newArray[j] = _array[j];
                    }
                    for (int j = index + 1; j < _array.Length; j++)
                    {
                        newArray[i - 1] = _array[i];
                    }
                    break;
                }
            }

            _array = newArray;
        }

        public int this [int index]
        {
            get { return _array[index]; }
            set { _array[index] = value; }
        }

        public void Swap(ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return _array[i];
            }
        }

        public MyList(int capasity)
        {
            _array = new int[capasity];
        }

        public MyList(int[] array)
        {
            _array = new int[(int)(_array.Length)];
            for (int i = 0; i < _array.Length; i++)
            {
                _array[i] = _array[i];
            }

            _currentCount = array.Length;
        }

        private void Resize(int newSize)
        {
            if (newSize <= 0)
            {
                throw new ArgumentNullException("Item can't be 0 or less");
            }

            int[] newArray = new int[newSize];

            for (int i = 0; i < _array.Length; i++)
            {
                newArray[i] = _array[i];
            }

            _array = newArray;
        }

        private Exception IndexOutOfRangeException(string v)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

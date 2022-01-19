using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyListProgram
{
    public interface IList : IEnumerable<int>
    {
        void Add(int element);//to end
        void AddFirst(int element);
        void AddByIndex(int element, int index);
        void ChangeValueByIndex(int value, int index);
        void DeleteFromEnd();
        void DeleteFromStart();
        void DeleteByIndex(int index);
        void DeleteFromEndNElements(int number);
        void DeleteFromStartNElements(int number);
        void DeleteNElementsFromIndex(int number, int index);
        void DeleteByFirstNumber(int value);
        int GetValueByIndex(int index);
        int GetIndexByFirstNumber(int value);
        int GetMaxIndex();
        int GetMax();
        int GetMinIndex();
        int GetMin();
        void SortByAsc();
        void SortByDesc();
        void Reverse();

        int this[int index] { get; set; }
        int Count { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyListProgram
{
    public interface IList
    {
        void Add(int element);//to end
        void AddFront(int element);
        void DeleteFromEnd();
        void DeleteFromStart();
        void DeleteByIndex();
        void GetValueByIndex();
        void GetIndexByFirstValue();
    }
}

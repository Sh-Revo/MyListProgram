using System;

namespace MyListProgram
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Hello World!");
            MyList myList = new MyList();
            myList.Add(0);
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
            myList.Add(6);
            myList.Add(5);
            myList.Add(7);
            myList.AddByIndex(20, 2);
            //myList.AddFirst(15);
            myList.DeleteFromEnd();

            myList.DeleteByIndex(2);
            myList.ChangeValueByIndex(2, 7);
            // myList.DeleteFromEnd();
            myList.SortByDesc();
            foreach (var item in myList)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
            //myList.Reverse();
            //foreach (var item in myList)
            //{
            //    Console.Write($"{item}\t");
            //}
            Console.WriteLine("\n" + myList.Count);
            Console.WriteLine(myList.GetValueByIndex(1));
            Console.WriteLine(myList.GetIndexByFirstNumber(5));
            Console.WriteLine(myList.GetMaxIndex());
            Console.WriteLine(myList.GetMax());
            Console.WriteLine(myList.GetMinIndex());
            Console.WriteLine(myList.GetMin());
        }
    }
}

using System;

namespace MyListProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyList myList = new MyList();
            myList.AddBack(1);
            myList.AddBack(2);
            myList.AddBack(3);
            myList.AddBack(4);
            myList.AddBack(5);
            myList.AddBack(6);
            myList.AddBack(7);
            myList.AddByIndex(20, 8);
            myList.AddFirst(15);

            // myList.DeleteFromEnd();
            for (int i = 0; i < myList.Length; i++)
            {
                Console.WriteLine(myList[i]);
                
            }
        }
    }
}

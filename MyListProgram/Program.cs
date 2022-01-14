using System;

namespace MyListProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyList myList = new MyList();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
            myList.Add(6);
            myList.Add(7);
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

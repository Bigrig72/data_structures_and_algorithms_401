using LinkedList.classes;
using System;

namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            NodeTraverse();

        }

       static void NodeTraverse()
        {
            LList list = new LList();
            list.Insert(6);
            list.Insert(8);
            list.Insert(12);

            Console.WriteLine($" does 8 exist: {list.Includes(8)}");
            Console.WriteLine($" does 6 exist: {list.Includes(6)}");
            Console.WriteLine($" does 12 exist: {list.Includes(8)}");

            list.Print();

            list.Append(16);
            list.Append(25);
            list.Append(30);

            Console.WriteLine($" does 30 exist: {list.Includes(30)}");


            list.InsertBefore(25, 53);
            list.InsertAfter(53, 31);

            list.Print();



        }
    }
}

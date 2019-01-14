using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.classes
{
    public class LList
    {

        public Node Head { get; set; }
        public Node Current { get; set; }

        public void Insert(int value)
        {
            Node node = new Node(value);
            node.Next = Head;
            Head = node;
        }

        public bool Includes(int value)
        {
            //set current to head because you dont traverse with the head
            Current = Head;


            //We are not at the end of the list
            while (Current.Next != null)
            {
                if(Current.Value == value)
                {
                    return true;
                }
                Current = Current.Next;                         
            }
            if (Current.Value == value)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Traverse from head and print all nodes values
        /// </summary>
        public void Print()
        {
            Console.Write("Head ->");
            Node Current = Head;

            while(Current.Next != null){
                Console.Write(Current.Value);
                Console.Write("->");
                Current = Current.Next;

            }
            Console.Write("NULL");
        }
    }
}

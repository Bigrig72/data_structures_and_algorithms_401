using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// Reassigning the head to current to be able to travers through the node tree
/// </summary>
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
        /// <summary>
        /// Checking to see if a value is included in the Linked List
        /// </summary>
        /// <param name="value"></param>
        /// <returns>
        /// True if current value equals value, will keep going until it reaches Null
        /// False if Null of hit the end of the tree
        /// </returns>

        public bool Includes(int value)
        {
            //set current to head because you dont traverse with the head
            Current = Head;


            //We are not at the end of the list
            while (Current.Next != null)
            {
                if (Current.Value == value)
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
            if (Head != null)
            {
                Current = Head;

                while (Current.Next != null)
                {
                    Console.Write($"{Current.Value} => ");

                    Current = Current.Next;

                }
                Console.Write($"{Current.Value} NULL");
                Console.WriteLine("");
            }

            else
            {
                Console.Write("Your LL is empty");
            }
        }
        public void Append(int value)
        {
            Current = Head;

            while (Current.Next != null)
            {
          
                Current = Current.Next;

            }

            Node node = new Node(value);
            Current.Next = node;

        }

        public void InsertBefore(int value, int newValue)
        {
            Current = Head;

            if(Current.Value == value)
            {
                Insert(newValue);
                return;
            }

            while(Current.Next != null)
            {
                if(Current.Next.Value == value)
                {
                    Node node = new Node(newValue);
                    node.Next = Current.Next;
                    Current.Next = node;
                    return;
                }

                Current = Current.Next;
            }
        }
        public void InsertAfter(int value, int newValue)
        {
            Current = Head;

            if (Current.Value == value)
            {
                Insert(newValue);
                return;
            }

            while (Current.Next != null)
            {
                if (Current.Value == value)
                {
                    Node node = new Node(newValue);
                    node.Next = Current.Next;
                    Current.Next = node;
                    return;
                }

                Current = Current.Next;
            }
        }
    }
}

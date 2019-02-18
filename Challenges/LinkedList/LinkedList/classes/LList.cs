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

        public void Insert(Object value)
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

        public bool Includes(Object value)
        {
            //set current to head because you dont traverse with the head
            Current = Head;


            //We are not at the end of the list
            while (Current.Next != null)
            {
                if (Current.Value.Equals(value))
                {
                    return true;
                }
                Current = Current.Next;
            }
            if (Current.Value.Equals(value))
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
        public void Append(Object value)
        {
            Node node = new Node(value);
            Current = Head;
            if (Head == null)
            {
                Head = node;
            }
            Current = Head;

            while (Current.Next != null)
            {
                Current = Current.Next;

            }          
            Current.Next = node;

        }
        public void Append(Object key, Object value)
        {
            Node node = new Node(key,value);
            if(Head == null)
            {
                Head = node;
            }
            else {
                Current = Head;
                while (Current.Next != null)            {

                    Current = Current.Next;
                }
                Current.Next = node;
            }

        }

        public void InsertBefore(Object value, Object newValue)
        {
            Current = Head;

            if(Current.Value.Equals(value))
            {
                Insert(newValue);
                return;
            }

            while(Current.Next != null)
            {
                if(Current.Next.Value.Equals(value))
                {
                    Node node = new Node(newValue);
                    node.Next = Current.Next;
                    Current.Next = node;
                    return;
                }

                Current = Current.Next;
            }
        }
        public void InsertAfter(Object value, Object newValue)
        {
            Current = Head;

            if (Current.Value.Equals(value))
            {
                Insert(newValue);
                return;
            }

            while (Current.Next != null)
            {
                if (Current.Value.Equals(value))
                {
                    Node node = new Node(newValue);
                    node.Next = Current.Next;
                    Current.Next = node;
                    return;
                }

                Current = Current.Next;
            }
        }

        public Object Find(Object key)
        {
            Current = Head;
            while(Current != null)
            {
                if(Current.Key == key)
                {
                    return Current.Value;
                }
                Current = Current.Next;
            }
            return null;
        }
    }
}

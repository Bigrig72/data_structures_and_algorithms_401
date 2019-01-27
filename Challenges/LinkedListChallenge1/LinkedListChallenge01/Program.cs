using System;
using LinkedList.classes;


namespace LinkedListChallenge01
{
    public class Program
    {
        static void Main(string[] args)
        {
            PlaceFromEnd(3);
        }

        public static int PlaceFromEnd(int value)
        {

            // Start counter to travers through the list
            int counter = 0;
            // Create new list
            LList list = new LList();

            list.Insert(1);
            list.Insert(2);
            list.Insert(3);
            list.Insert(4);
            list.Insert(5);
            list.Insert(6);
            // Define what current is 
            list.Current = list.Head;
            // Run throught the list untill the end and increment a counter until the end
            while (list.Current.Next != null)
            {
                counter++;
                list.Current = list.Current.Next;
            }

            // Start the list over to get another counter to match that counter with the current value then retur that value
            list.Current = list.Head;
            int position = (counter + 2) - (value + 1);
            int counter2 = 0;
            while (list.Current.Next != null)
            {
                counter2++;

                if (position == counter2)
                {
                    Console.WriteLine(list.Current.Value);
                    return list.Current.Value;
                }
                list.Current = list.Current.Next;
            }

            Console.WriteLine(position);
            
            return -1;
        }
    }
}
    


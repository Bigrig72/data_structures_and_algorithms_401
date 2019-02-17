using System;

namespace InsertionSort
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { 9, 5, 7, 2, 1, 3, 19 };
            Sort anyArray = new Sort(array);
            anyArray.InsertionSort();

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Value: {array[i]}");
            }

        }
    }
}
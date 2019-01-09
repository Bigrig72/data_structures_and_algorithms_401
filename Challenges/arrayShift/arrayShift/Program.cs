using System;

namespace arrayShift
{
    class Program
    {
        static void Main(string[] args)
        {

     
            int[] shiftedArray = ArrayShift(new int []{ 3, 4, 5, 6 }, 9);

            Console.WriteLine($"New Array: {string.Join(",", shiftedArray)}");
            Console.ReadLine();
        }

       private static int[] ArrayShift(int[] oldArray, int newNumber)

        {
            int oldArrayLength = oldArray.Length;
            int newArrayLength = oldArrayLength + 1;

            int[] newArray = new int[newArrayLength];

            for (int i = 0; i < oldArrayLength / 2; i++)
            {
                newArray[i] = oldArray[i];
            }

            newArray[oldArrayLength/2] = newNumber;

            for (int i = oldArrayLength/2; i < oldArrayLength; i++)
            {
                newArray[i + 1] = oldArray[i];
            }

            return newArray;
        }
    }
}

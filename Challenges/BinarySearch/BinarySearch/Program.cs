using System;

namespace Code_challenge_03
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Giving an array to use, it is an assorted array in order, we will be chaecking to see if 
            //our key exists and if it does returning the index
            
            int[] assortedArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };

            //Asking for user input
            Console.WriteLine("Please enter the number you search 1-18: ");
            int searchForNum = Convert.ToInt32(Console.ReadLine());

            //Giving back the data we asked for by calling our method assorted array and passing the created array and our search number
            Console.WriteLine("We found at index: " + BinarySearch(assortedArray, searchForNum));
            Console.ReadKey();
        }

        //Method to do binary search
        public static int BinarySearch(int[] assortedArray, int num)
        {
            //Declaring left and right side of array and midpoint
            int leftSide = 0;
            int rightSide = assortedArray.Length - 1;
            int midPoint;

            //Creating while loop to evaluate if the number passed in matches the midpoint, loop will continue to run
            //Until conditions are not true
            while (leftSide <= rightSide)
            {
                midPoint = (leftSide + rightSide) / 2;

                if (assortedArray[midPoint] == num)
                {
                    return midPoint;
                }
                else
                {
                    // If it does not equal the midpoint reassign that midpoint and repeat the process
                    if (assortedArray[midPoint] > num)
                    {
                        rightSide = midPoint - 1;
                    }
                    else
                    {
                        leftSide = midPoint + 1;
                    }
                }
            }

            //If no key is found return -1
            return -1;

        }
    }
}
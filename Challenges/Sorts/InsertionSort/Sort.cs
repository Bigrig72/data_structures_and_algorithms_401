using System;
using System.Collections.Generic;
using System.Text;

namespace InsertionSort
{
    public class Sort
    {
        private int[] Arr;
        public Sort(int[] array)
        {
            Arr = array;
        }

        private bool More(int leftInt, int rightInt)
        {
            return leftInt > rightInt;
        }
        public void InsertionSort()
        {
            int Size = Arr.Length;
            int temp, j;
            for (int  i = 1;  i < Size;  i++)
            {
                temp = Arr[i];

                for (j = i; j > 0 && More(Arr[j - 1], temp); j--)
                {
                    Arr[j] = Arr[j - 1];
                }
                Arr[j] = temp;
            }
        }
    }
}

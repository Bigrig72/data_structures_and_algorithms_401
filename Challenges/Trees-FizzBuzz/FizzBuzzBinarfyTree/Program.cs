using System;
using FizzBuzzBinarfyTree.Classes;
using FizzBuzzBinaryTree.Classes;
using 

namespace FizzBuzzBinarfyTree
{
    public class Program
    {

        static void Main(string[] args)
        {


        }


        public static void FizzBuzzTree(Root root)
        {
            if(root != null)
            {
                
            }
        
            if ((int)root.Value % 15 == 0)
            {

     
                root.Value = "Fizzbuzz";
            }
            else if ((int)root.Value % 5 == 0)
            {
                root.Value = "Fizz";
            }
            else if ((int)root.Value % 3 == 0)
            {
                root.Value = "Buzz";
            }
            else
            {
                if ((int)root.Right.Value % 3 == 0 & (int)root.Right.Value % 5 == 0)
                {
                    root.Value = "FizzBuzz";
                }
                else if ((int)root.Right.Value % 5 == 0)
                {
                    root.Value = "Fizz";
                }
                else if ((int)root.Right.Value % 3 == 0)
                {
                    root.Value = "Buzz";
                }
            }
        }
    }
}

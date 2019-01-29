using System;
using Trees.classes;

namespace FizzBuzzBinarfyTree
{
    public class Program
    {
        static void Main(string[] args)
        {
          

        }

        public static void FizzBuzzTree(BinaryTree binaryTree)
        {
            if(binaryTree.Top == null)
            {
                return;
            }
            if(binaryTree.Top.Left.Value % 3 == 0 & binaryTree.Top.Left.Value % 5 == 0)
            {
                binaryTree.Top.Left.Value = "FizzBuzz";
            }
        }
    }
}

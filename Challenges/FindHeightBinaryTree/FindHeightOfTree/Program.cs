using System;
using Trees.Classes;

namespace FindHeightOfTree
{
   public class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Test Binary Tree");
            Node root = new Node(15);
            root.Left = new Node(20);
            root.Right = new Node(30);
            root.Left.Left = new Node(25);
            root.Left.Right = new Node(35);
            root.Right.Left = new Node(10);
            root.Right.Right = new Node(19);
            
            Console.WriteLine($"The height of the tree is: {CalculateBinaryTreeDepth(root)}");
            Console.WriteLine($"The Depth of the tree is: {CalculateBinaryTreelevel(root)}");
        }

        
        public static int CalculateBinaryTreeDepth(Node root)
        {
            int leftHeight = 0;
            int rightHeight = 0;

            if(root.Left != null)
            {
                leftHeight = 1 + CalculateBinaryTreeDepth(root.Left);
            }
            if(root.Right != null)
            {
                rightHeight = 1 + CalculateBinaryTreeDepth(root.Right);
            }
            return leftHeight > rightHeight ? leftHeight : rightHeight;
        }

        public static int CalculateBinaryTreelevel(Node root)
        {
            if(root == null)
            {
                return 0;
            }
            else
            {
                int leftDepth = CalculateBinaryTreelevel(root.Left);
                int rightDepth = CalculateBinaryTreelevel(root.Right);
                if(leftDepth > rightDepth)
                {
                    return (leftDepth + 1);
                }
                else
                {
                    return (rightDepth + 1);
                }
            }
        }
    }
}

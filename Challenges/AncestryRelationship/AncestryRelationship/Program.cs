using System;
using Trees.Classes;

namespace AncestryRelationship
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

            Console.WriteLine($"Are these two node cousins: {IsAncestor(root,root.Left.Left,root.Right)}");
        }
        public static bool IsAncestor(Node root, Node a, Node b)
        {
            if(root == null)
            {
                return false;
            }
            return ((root.Left == a && root.Right == b) ||
                    (root.Left == b && root.Right == a) ||
                            IsAncestor(root.Left, a, b) ||
                            IsAncestor(root.Right, a, b));
        }
    }
}

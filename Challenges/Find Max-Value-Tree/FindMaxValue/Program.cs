using System;
using Trees.Classes;

namespace FindMaxValue
{
   public class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();

            Node node1 = new Node(15);
            Node node2 = new Node(25);
            Node node3 = new Node(35);
            Node node4 = new Node(45);
            Node node5 = new Node(55);
            Node node6 = new Node(65);
            Node node7 = new Node(75);

            node1.Left = node2;
            node1.Right = node3;
            node2.Left = node4;
            node2.Right = node5;
            node3.Left = node6;
            node3.Right = node7;

            tree.Top = node1;
            FindMaxValue(node1.Value, 0);

        }

        private static void FindMaxValue(int value, int v)
        {
            throw new NotImplementedException();
        }

        public static int FindMaxValue(Node root, int maxValue)
        {
            maxValue = 0;
           
            if(maxValue < root.Value)
            {
                maxValue = root.Value;
            }
            if(root.Left != null)
            {
                FindMaxValue(root.Left.Value, maxValue);
            }
            if(root.Right != null)
            {
                FindMaxValue(root.Right.Value, maxValue);
            }
            return maxValue;
            
        }

    }
}

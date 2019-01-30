using System;
using System.Collections.Generic;
using Trees.Classes;

namespace BreadthFirst
{
   public class Program
    {
        static void Main(string[] args)
        {
            
            List<object> valueList = new List<object>();
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
          
           BreadthFirst(tree.Top, valueList);

            foreach (var item in valueList)
            {
                Console.WriteLine(item + ", ");
            }

        }

        public static void BreadthFirst(Node node, List<object> valueList)
        {
            var NewQueue = new Queue<Node>();
            NewQueue.Enqueue(node);
            while (NewQueue.Count > 0)
            {
                var current = NewQueue.Dequeue();
                if (current == null)
                {
                    continue;
                }
                NewQueue.Enqueue(current.Left);
                NewQueue.Enqueue(current.Right);
                valueList.Add(current.Value);
            }
        }
    }
}

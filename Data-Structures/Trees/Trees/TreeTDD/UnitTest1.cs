using System;
using Xunit;
using Trees.Classes;
using System.Collections.Generic;

//namespace TreeTDD
//{
//    public class UnitTest1
//    {
//        /// <summary>
//        /// Adding a node to the tree
//        /// </summary>
//        [Fact]
//        public void AddingNode()
//        {
//            BinarySearchTree tree = new BinarySearchTree();
//            tree.Add(15);
//            Assert.Equal(15, tree.Top.Value);
//        }
//        /// <summary>
//        /// Checking to see if a value is contained in the list
//        /// </summary>
//        [Fact]
//        public void ValueIsConainedInTree()
//        {
//            List<int> valueList = new List<int>();
//            Node node = new Node(15);
//            var NewQueue = new Queue<Node>();
//            NewQueue.Enqueue(node);

//            valueList.Add(node.Value);
//            bool isfound = valueList.Contains(node.Value);

//            Assert.Equal(valueList.Contains(15), isfound);
//        }
//        [Fact]
//        public void PreOrderCheck()
//        {
//            Node node1 = new Node(5);
//            Node node2 = new Node(10);
//            Node node3 = new Node(15);
//            Node node4 = new Node(20);
//            Node node5 = new Node(25);
//            Node node6 = new Node(30);

//            BinaryTree tree = new BinaryTree(node1.Value);
//            node1.Left = node2;
//            node1.Right = node3;
//            node2.Left = node4;
//            node2.Right = node5;
//            node3.Left = node6;

//            List<int> AddNodeList = new List<int>();
//            tree.PreOrder(node1, AddNodeList);


//            List<int> valueList = new List<int>();
//            valueList.Add(node1.Value);
//            valueList.Add(node2.Value);
//            valueList.Add(node4.Value);
//            valueList.Add(node5.Value);
//            valueList.Add(node3.Value);
//            valueList.Add(node6.Value);

//            Assert.Equal(AddNodeList[0], valueList[0]);
//        }
//    }
//}

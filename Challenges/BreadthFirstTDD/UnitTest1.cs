using System;
using Xunit;
using BreadthFirst;
using Trees.Classes;
using System.Collections.Generic;

namespace BreadthFirstTDD
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            List<object> valueList = new List<object>();
            BinaryTree tree = new BinaryTree();

            Node node1 = new Node(5);
            Node node2 = new Node(10);
            Node node3 = new Node(15);
            Node node4 = new Node(20);
            Node node5 = new Node(25);
            Node node6 = new Node(30);

            node1.Left = node2;
            node1.Right = node3;
            node2.Left = node4;
            node2.Right = node5;
            node3.Left = node6;

            tree.Top = node1;
           
           

            List<object> valueList2 = new List<object>();
            valueList.Add(node1.Value);
            valueList.Add(node2.Value);
            valueList.Add(node4.Value);
            valueList.Add(node5.Value);
            valueList.Add(node3.Value);
            valueList.Add(node6.Value);

            Assert.Equal(AddNodeList[0], valueList[0]);


        }
    }
}

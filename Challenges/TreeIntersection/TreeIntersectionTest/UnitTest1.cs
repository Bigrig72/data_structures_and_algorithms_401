using System;
using Xunit;
using TreeIntersectionHashTable;
using Trees.Classes;
using System.Collections.Generic;

namespace TreeIntersectionTest
{
    public class UnitTest1
    {/// <summary>
    /// Building 2 trees and running our method which will add both trees into a preorder check,
    /// added to a list, then hashed. This shows that method can successfully check duplicated values across both trees
    /// </summary>
        [Fact]
        public void CheckForDuplicateValuesInBinaryTrees()
        {
            BinaryTree root = new BinaryTree();
            root.Top = new Node(40);
            root.Top.Left = new Node(20);
            root.Top.Right = new Node(30);
            root.Top.Left.Left = new Node(25);
            root.Top.Left.Right = new Node(35);
            root.Top.Right.Left = new Node(10);
            root.Top.Right.Right = new Node(19);


            BinaryTree root2 = new BinaryTree();
            root2.Top = new Node(35);
            root2.Top.Left = new Node(90);
            root2.Top.Right = new Node(30);
            root2.Top.Left.Left = new Node(19);
            root2.Top.Left.Right = new Node(55);
            root2.Top.Right.Left = new Node(10);
            root2.Top.Right.Right = new Node(50);

            List<int> list1 = new List<int>();

            List<int> list2 = new List<int>();

            List<int> final = Program.TreeIntersection(list1, list2, root, root2);

            List<int> test = new List<int>();
            test.Add(35);
            test.Add(30);
            test.Add(10);
            test.Add(19);

            Assert.Equal(final, test);

        }
        /// <summary>
        ///  Checking to see if both trees have same values and being delivered to a list. This test
        ///  asserts we can check the top head node as well.
        /// </summary>
        [Fact]
        public void CheckForDuplicateValuesInBinaryTrees2()
        {
            BinaryTree root = new BinaryTree();
            root.Top = new Node(40);
            root.Top.Left = new Node(20);
            root.Top.Right = new Node(30);
            root.Top.Left.Left = new Node(25);
            root.Top.Left.Right = new Node(35);
            root.Top.Right.Left = new Node(10);
            root.Top.Right.Right = new Node(5);


            BinaryTree root2 = new BinaryTree();
            root2.Top = new Node(40);
            root2.Top.Left = new Node(20);
            root2.Top.Right = new Node(30);
            root2.Top.Left.Left = new Node(5);
            root2.Top.Left.Right = new Node(55);
            root2.Top.Right.Left = new Node(10);
            root2.Top.Right.Right = new Node(50);

            List<int> list1 = new List<int>();

            List<int> list2 = new List<int>();

            List<int> final = Program.TreeIntersection(list1, list2, root, root2);

            List<int> test = new List<int>();
           if(root.Top == root2.Top)
            {
                test.Add(root.Top.Value);
            }

            test.Add(20);
            test.Add(30);
            test.Add(10);
            test.Add(5);

            Assert.Equal(final, test);

        }
    }
}

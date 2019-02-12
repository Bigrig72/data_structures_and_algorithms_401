using System;
using Xunit;
using Trees.Classes;
using AncestryRelationship;

namespace AncestryTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestTrueIfNodeHasCousin()
        {
            Node root = new Node(15);
            root.Left = new Node(20);
            root.Right = new Node(30);
            root.Left.Left = new Node(25);
            root.Left.Right = new Node(35);
            root.Right.Left = new Node(10);
            root.Right.Right = new Node(19);

            var cousin = Program.IsAncestor(root, root.Left, root.Right);
            Assert.True(cousin);
        }
        [Fact]
        public void TestTrueIfNodeHasCousin2()
        {
            Node root = new Node(15);
            root.Left = new Node(20);
            root.Right = new Node(30);
            root.Left.Left = new Node(25);
            root.Left.Right = new Node(35);
            root.Right.Left = new Node(10);
            root.Right.Right = new Node(19);

            var cousin = Program.IsAncestor(root, root.Left.Left, root.Right);
            Assert.False(cousin);
        }
    }
}

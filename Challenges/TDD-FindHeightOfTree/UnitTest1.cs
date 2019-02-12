using Xunit;
using Trees.Classes;
using FindHeightOfTree;

namespace TDD_FindHeightOfTree
{
    public class UnitTest1
    {
        [Fact]
        public void CheckTheHeightOfTheTree()
        {
            Node root = new Node(15);
            root.Left = new Node(20);
            root.Right = new Node(30);
            root.Left.Left = new Node(25);
            root.Left.Right = new Node(35);
            root.Right.Left = new Node(10);
            root.Right.Right = new Node(19);

           var findHeight = Program.CalculateBinaryTreeDepth(root);

            Assert.Equal(2, findHeight);
        }
        [Fact]
        public void CheckTheDepthOfTheTree()
        {
            Node root = new Node(15);
            root.Left = new Node(20);
            root.Right = new Node(30);
            root.Left.Left = new Node(25);
            root.Left.Right = new Node(35);
            root.Right.Left = new Node(10);
            root.Right.Right = new Node(19);

            var findLevel = Program.CalculateBinaryTreelevel(root);

            Assert.Equal(3, findLevel);
        }      
    }
}

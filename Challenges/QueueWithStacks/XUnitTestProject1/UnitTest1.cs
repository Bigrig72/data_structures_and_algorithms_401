using queue_with_stacks.classes;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        // Assuring I can Create a node
        public void AbleToCreateANode()
        {
            Node node = new Node(5);
            Assert.Equal(5, node.Value);
        }
        [Fact]
        // Assuring I can Create a node
        public void AbleToCreateANode2()
        {
            Node node = new Node(15);
            Assert.Equal(15, node.Value);
        }
        [Fact]
        // Assuring I can Create a node
        public void AbleToCreateANode3()
        {
            Node node = new Node(25);
            Assert.Equal(25, node.Value);
        }
    }
}

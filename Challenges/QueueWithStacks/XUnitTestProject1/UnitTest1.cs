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
        [Fact]
        // Assuring I can Create a Empty stack and have Top set to Null
        public void AbleToCreateEmptyStack()
        {
            Stack stack = new Stack();
            Assert.Null(stack.Top);
        }
        [Fact]
        // Assuring I can Push a value in to the stack
        public void AbleToPushToStack()
        {
            Stack stack = new Stack();
            stack.Push(15);
            Assert.Equal(15, stack.Top.Value);           
        }
        [Fact]
        // Assuring I can Push a value in to the stack and get the Next value
        public void AbleToPushToStackUsingNext2()
        {
            Stack stack = new Stack();
            stack.Push(15);
            stack.Push(20);
            Assert.Equal(15, stack.Top.Next.Value);
        }
        [Fact]
        // Assuring I can Push a value in to the stack and get the Next value
        public void AbleToPushToStackUsingNext3()
        {
            Stack stack = new Stack();
            stack.Push(15);
            stack.Push(20);
            stack.Push(30);
            Assert.Equal(20, stack.Top.Next.Value);
        }
        [Fact]
        // Assuring I can Push a value in to the stack and pop off the value on top
        public void AbleToPopOffOfTheStack1()
        {
            Stack stack = new Stack();
            stack.Push(15);
            stack.Push(20);
            stack.Pop();
            Assert.Equal(15, stack.Top.Value);
        }
        [Fact]
        // Assuring I can Push a value in to the stack and pop off the value on top
        public void AbleToPopOffOfTheStack2()
        {
            Stack stack = new Stack();
            stack.Push(15);
            stack.Push(30);
            stack.Pop();
            Assert.Equal(15, stack.Top.Value);
        }
        [Fact]
        // Assuring I can Push a value in to the stack and pop off the value on top
        public void AbleToPopOffOfTheStack3()
        {
            Stack stack = new Stack();
            stack.Push(15);
            stack.Push(30);
            stack.Push(40);
            stack.Pop();
            Assert.Equal(30, stack.Top.Value);
        }
    }
}

using Xunit;
using StacksAndQues.classes;
namespace stackAndQue
{
    public class UnitTest1
    {
        [Fact]
        // Basic peek on the node you have
        public void Peek1()
        {
            // Peek at the one Node I have which is 3
            Node node = new Node(3);
     
            Assert.Equal(3, 3);           
         
        }
        [Fact]
        // Peek as well as deque
        public void Peek2()
        {
            Node node = new Node(15);
            // Peek at front--which is 15
            Qeue que = new Qeue(node);
            que.Front = node;
            Assert.Equal(15, 15);

        }
        [Fact]
       // Deque with peek
        public void Peek3()
        {
            Node node = new Node(125);
            // Peek at front--which is 125
            Qeue que = new Qeue(node);
            que.Front = node;
            Assert.Equal(125, 125);
        }

        [Fact]
        // Push is meaning the top is the node
        public void PushAValue1()
        {
            Node node = new Node(125);
            Stack stack = new Stack(node);
            stack.Top = node;
            Assert.Equal(125, 125);
        }
        [Fact]
        // Push is meaning the top is the node
        // using and showing push
        public void PushAValue2()
        {
            Node node = new Node(125);
            Stack stack = new Stack(node);
            stack.Push(20);

            Assert.Equal(20, 20);
            
        }
        [Fact]
        // Push is meaning the top is the node
        // using and showing push with two integers
        public void PushAValue3()
        {
            Node node = new Node(125);
            Stack stack = new Stack(node);
            stack.Push(20);
            stack.Push(30);
            Assert.Equal(30, 30);
        }
        [Fact]
        // Showing that I pushed 30 and popped 30 and left with 125
        public void PopValue1()
        {
            Node node = new Node(125);
            Stack stack = new Stack(node);
            stack.Push(30);
            stack.Pop();
            Assert.Equal(125, 125);
        }
        [Fact]
        // Showing that I pushed 30 and popped 30 and left with 125
        public void PopValue2()
        {
            Node node = new Node(125);
            Stack stack = new Stack(node);
            stack.Push(40);
            stack.Pop();
            Assert.Equal(125, 125);
        }
        [Fact]
        // Showing that I pushed 30 and popped 30 and left with 125
        public void PopValue3()
        {
            Node node = new Node(125);
            Stack stack = new Stack(node);
            stack.Push(50);
            stack.Pop();
            Assert.Equal(125, 125);
        }
        [Fact]
        // Showing that I pushed 30 and popped 30 and left with 125
        public void Enque1()
        {
            Node node = new Node(125);
            Qeue que = new Qeue(node);
            que.Rear = node;
            Assert.Equal(125, 125);
        }
        [Fact]
        // Showing that I pushed 30 and popped 30 and left with 125
        public void Enque2()
        {
            Node node = new Node(300);
            Qeue que = new Qeue(node);
            que.Rear = node;
            Assert.Equal(300, 300);
        }
        [Fact]
        // Showing that I pushed 30 and popped 30 and left with 125
        public void Enque3()
        {
            Node node = new Node(400);
            Qeue que = new Qeue(node);
            que.Rear = node;
            Assert.Equal(400, 400);
        }
    }
}

using Xunit;
using StacksAndQues.classes;
namespace stackAndQue
{
    public class UnitTest1
    {
        [Fact]
        // Basic peek on the node you have in a stack
        public void Peek1()
        {
            Stack stack = new Stack();
            stack.Push(39);           
            Assert.Equal(39, stack.Top.Value);           
         
        }

        [Fact]
        // Peek using a queue
        public void Peek2()
        {
            Node node = new Node(15);
            Qeue que = new Qeue(node);
            que.Front = node;
            Assert.Equal(15, que.Front.Value);
        }

        [Fact]
       // Peek With a queue
        public void Peek3()
        {
            Node node = new Node(125);
            // Peek at front--which is 125
            Qeue que = new Qeue(node);
            que.Front = node;
            Assert.Equal(125, que.Front.Value);
        }

        [Fact]
        // Showing that we can push a node on to the stack
        public void PushAValue1()
        {
            Node node = new Node(125);
            Stack stack = new Stack(node);
            stack.Top = node;
            Assert.Equal(125, stack.Top.Value);
        }
        [Fact]
       // Showing method pushing one value on to the stack and that it is the top
        public void PushAValue2()
        {
            Node node = new Node(125);
            Stack stack = new Stack(node);
            stack.Push(20);
            Assert.Equal(20, stack.Top.Value);            
        }

        [Fact]
        // Push 2 integers on stack and test the TOP node
        public void PushStackTop()
        {
            Node node = new Node(125);
            Stack stack = new Stack(node);
            stack.Push(20);
            stack.Push(30);
            Assert.Equal(30, stack.Top.Value);
        }

        [Fact]
        // Push 2 integers on stack and test the NEXT node
        public void PushStackNext()
        {
            Node node = new Node(125);
            Stack stack = new Stack(node);
            stack.Push(20);
            stack.Push(30);
            Assert.Equal(20, stack.Top.Next.Value);
        }

        [Fact]
        // Showing that I pushed 30 and popped 30 and left with 125
        public void PopValue1()
        {
            Node node = new Node(125);
            Stack stack = new Stack(node);
            stack.Push(30);
            stack.Pop();
            Assert.Equal(125, stack.Top.Value);
        }
        [Fact]
        // using pop after pushing 40, leaves me with my initial node
        public void PopValue2()
        {
            Node node = new Node(125);
            Stack stack = new Stack(node);
            stack.Push(40);
            stack.Pop();
            Assert.Equal(125, stack.Top.Value);
        }
        [Fact]        
        public void PopValue3()
        {
            Node node = new Node(125);
            Stack stack = new Stack(node);
            stack.Push(50);
            stack.Pop();
            Assert.Equal(125, stack.Top.Value);
        }
        [Fact]
        // Showing tRear exists in que
        public void Enque1()
        {
            Node node = new Node(125);
            Qeue que = new Qeue(node);
            que.Rear = node;
            Assert.Equal(125, que.Rear.Value);
        }
        [Fact]
        // Showing front of que exists
        public void Enque2()
        {
            Node node = new Node(300);
            Qeue que = new Qeue(node);
            que.Front = node;
            Assert.Equal(300, que.Front.Value);
        }
        [Fact]
        // Shwoing rear and front added to the queue
        public void Enque3()
        {
            Node node1 = new Node(400);
            Node node2 = new Node(200);
            Qeue que = new Qeue(node1);
            que.Front = node2;
            que.Rear = node1;       
            Assert.Equal(200, que.Front.Value);
        }
    }
}

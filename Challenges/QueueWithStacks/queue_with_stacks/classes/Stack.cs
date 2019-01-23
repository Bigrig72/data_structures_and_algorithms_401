namespace queue_with_stacks.classes
{
    public class Stack
    {
        //top reference so we know where the top is

        public Node Top { get; set; }

        public Stack(Node node)
        {
            Top = node;
        }

        // Give us an empty stack

        public Stack()
        {
            Top = null;
        }

        // Push
        public void Push(int value)
        {
            Node node = new Node(value);
            node.Next = Top;
            Top = node;
        }
        // Pop
        public Node Pop()
        {
            // create a temp
            Node temp = Top;
            // set top to the next node in the stack
            Top = Top.Next;
            // clear the reference of next on the temp
            temp.Next = null;
            // return the node
            return temp;
        }
    }
}

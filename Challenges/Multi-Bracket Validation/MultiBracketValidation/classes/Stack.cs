using System;
using System.Collections.Generic;
using System.Text;

namespace MultiBracketValidation.classes
{
   public class Stack
    {
        public Node Top { get; set; }

        public Stack(Node node)
        {
            Top = node;
        }


        public Stack()
        {
            Top = null;
        }

        // Push
        public void Push(char value)
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

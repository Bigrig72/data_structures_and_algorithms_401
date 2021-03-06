﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQues.classes
{
    public class Qeue
    {
        public  Node Front { get; set; }
        public Node Rear { get; set; }

        public Qeue(Node node)
        {
            Front = node;
            Rear = node;
        }

        // Enqueue
        public void Enque(int value)
        {
            Node node = new Node(value);
            Rear.Next = node;
            Rear = node;
        }

        // Dequeue

        public Node Deque()
        {
            // create a temp to keep track of the original front
            Node temp = Front;
            // change our front reference to the next node
            Front = Front.Next;
            // clear our next reference for standalone
            temp.Next = null;
            // return the temp to the user
            return temp;
        }

         // Peek

        public Node Peek()
        {
            return Front;
        }

    }
}

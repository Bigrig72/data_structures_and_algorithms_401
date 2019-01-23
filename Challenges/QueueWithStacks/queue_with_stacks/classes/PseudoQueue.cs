using System;
using System.Collections.Generic;
using System.Text;

namespace queue_with_stacks.classes
{
    public class PseudoQueue
    {
        private Stack frontEnd;
        private Stack backEnd;

        public PseudoQueue()
        {
            frontEnd = new Stack();
            frontEnd.Top = null;

            backEnd = new Stack();
            backEnd.Top = null;
        }

        /// <summary>
        /// While Top node of backend is not Null , Pop each node from backend and Push it to front end.
        /// When fornt end becomes null, the new nodes will be assigned new values attached to the front end.
        ///summary>
        /// <param name="value"></param>
        public void Enqueue(int value)
        {
            while (backEnd.Top != null)
            {
                frontEnd.Push(backEnd.Pop().Value);
            }
            frontEnd.Push(value);
        }

        /// <summary>
        /// Pop from front end, push to back end.
        /// </summary>
        /// <param name="value"></param>
        public void Dequeue(int value)
        {
            while (frontEnd.Top != null)
            {
                backEnd.Push(frontEnd.Pop().Value);
            }
            backEnd.Push(value);
        }
    
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Node Peek()
        {
            while(frontEnd != null)
            {
                backEnd.Push(frontEnd.Pop().Value);
            }
            return backEnd.Top;
        }
    }
}
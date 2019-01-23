using System.Collections.Generic;

namespace XUnitTestProject1
{
    internal class Node<T>
    {
        private int v;

        public Node(int v)
        {
            this.v = v;
        }

        public IEnumerable<object> Value { get; internal set; }
    }
}
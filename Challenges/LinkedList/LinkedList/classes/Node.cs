using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Setting up NODE and what the value will be
/// </summary>
namespace LinkedList.classes
{
    public class Node
    {

        public Object Value { get; set; }
        public Node Next { get; set; }
        public Object Key { get; set; }
        

        public Node(Object value)
        {
            Value = value;
        }
        public Node(Object key, Object value)
        {
            Key = key;
            Value = value;
        }

    }
}

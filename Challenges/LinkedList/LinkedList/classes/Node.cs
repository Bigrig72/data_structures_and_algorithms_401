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

        public int Value { get; set; }
        public Node Next { get; set; }

        public Node(int value)
        {
            Value = value;
        }

    }
}

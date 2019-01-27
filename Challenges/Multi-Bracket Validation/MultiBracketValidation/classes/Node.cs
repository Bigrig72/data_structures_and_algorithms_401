﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MultiBracketValidation.classes
{
    public class Node
    {
            public char Value { get; set; }

            public Node Next { get; set; }

            public Node(char value)
            {
                Value = value;
            }
    }
}
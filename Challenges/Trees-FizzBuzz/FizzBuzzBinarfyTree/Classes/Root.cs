using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzBinarfyTree.Classes
{
    public class Root
    {
        public object Value { get; set; }
        public Root Left { get; set; }
        public Root Right { get; set; }

        public Root(object value)
        {

            Value = value;
            Left = null;
            Right = null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace fifo_animal_shelter.classes
{
    public class Cat: Animal
    {
        public Cat(string name)
        {
            Species = "cat";
            Name = name;
            Next = null;
        }


    }
    
}

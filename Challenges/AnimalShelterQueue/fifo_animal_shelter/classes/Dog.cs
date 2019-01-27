using System;
using System.Collections.Generic;
using System.Text;

namespace fifo_animal_shelter.classes
{
    public class Dog: Animal
    {
        public Dog(string name)
        {
            Species = "dog";
            Name = name;
            Next = null;
        }      
    }
}

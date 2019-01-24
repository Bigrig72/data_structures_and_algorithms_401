using System;
using System.Collections.Generic;
using System.Text;

namespace fifo_animal_shelter.classes
{
   public class AnimalShelter
    {
        public Queue Queue1 { get; set; }
        public Queue Queue2 { get; set; }

        public Queue Primary { get; set; }
        public Queue Secondary { get; set; }

        public AnimalShelter()
        {
            Queue1 = new Queue();
            Queue2 = new Queue();

            Primary = Queue1;
            Secondary = Queue2;
        }

        public void Enqueue(Animal newAnimal)
        {
            Primary.Enqueue(newAnimal);
        }
        
        public Animal Dequeue(string pref)
        {
            Animal temp = null;

            if(pref == "")
            {
                return Primary.Dequeue();
            }
            if(pref != "dog" && pref != "cat")
            {
                Console.WriteLine("This animal does not exist");
                return temp;
            }
            temp = Primary.Dequeue();
            // Checking to see if there is a match, if not send to secondary queue
            // If the primary has anything left in it after finding a match go ahead and send the rest to the second queue
            while(Primary.Front != null && temp.Species != pref)
            {
                Secondary.Enqueue(temp);
                temp = Primary.Dequeue();
            }
            while(Primary.Front != null)
            {
                Secondary.Enqueue(Primary.Dequeue());
            }
            Queue temp2;

            temp2 = Primary;
            Primary = Secondary;
            Secondary = temp2;

            return temp;
        }
    }
}

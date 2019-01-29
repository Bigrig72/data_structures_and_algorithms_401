using System;
using System.Collections.Generic;
using System.Text;

namespace fifo_animal_shelter.classes
{
   public class Queue
    {
        public Animal Front { get; set; }
        public Animal Rear { get; set; }

        public Queue()
        {
            Front = null;
            Rear = null;
        }
        /// <summary>
        /// Adding a new animal to the rear of queue
        /// </summary>
        /// <param name="animal"></param>
        public void Enqueue(Animal animal)
        {
            if(Rear != null)
            {
                Rear.Next = animal;
            }
            if(Front == null)
            {
                Front = animal;
            }
            Rear = animal;
        }
        /// <summary>
        /// returns and removes the animal from the front of the queue
        /// </summary>
        /// <returns></returns>
        public Animal Dequeue()
        {
            Animal temp = null;
            temp = Front;
            try
            {
                Front = Front.Next;
                temp.Next = null;

                if(Front == null)
                {
                    Rear = null;
                }
            }
            catch (Exception ex)
            {          
                Console.WriteLine($"The shelter is now empty: {ex.Message}");
                throw;
            }
            return temp;
        }
        public Animal Peek()
        {
            return Front;
        }
    }
}

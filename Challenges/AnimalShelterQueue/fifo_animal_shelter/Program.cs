using System;
using fifo_animal_shelter.classes;

namespace fifo_animal_shelter
{
    public class Program
    {
        static void Main(string[] args)
        {
            AnimalShelter shelter = new AnimalShelter();
            FIFOanimalShelter(shelter);

            Console.ReadLine();
        }

        static void FIFOanimalShelter(AnimalShelter shelter)
        {
            Console.WriteLine("Shelter is empty");
            Console.WriteLine("Take dog away from empty shelter");
            shelter.Dequeue("dog");

            Console.WriteLine("Tak cat away from empty shelter");
            shelter.Dequeue("cat");


            Console.WriteLine("Add in some animals to the shelter");

            Dog nena = new Dog("nena");
            Dog bandit = new Dog("bandit");
            Cat alpine = new Cat("alpine");
            Cat ruby = new Cat("ruby");


            Console.WriteLine("Add these new dogs into the shelter");

            shelter.Enqueue(nena);
            Console.WriteLine($"Successfully added: {shelter.Primary.Rear.Name} the {shelter.Primary.Rear.Species} to the shelter");
            shelter.Enqueue(bandit);
            Console.WriteLine($"Successfully added: {shelter.Primary.Rear.Name} the {shelter.Primary.Rear.Species} to the shelter");
            shelter.Enqueue(alpine);
            Console.WriteLine($"Successfully added: {shelter.Primary.Rear.Name} the {shelter.Primary.Rear.Species} to the shelter");
            shelter.Enqueue(ruby);
            Console.WriteLine($"Successfully added: {shelter.Primary.Rear.Name} the {shelter.Primary.Rear.Species} to the shelter");

            Console.WriteLine("Lets adopt some animals");
            Animal adopted = shelter.Dequeue("dog");
            Console.WriteLine($"You have adopted {adopted.Name}, which is a {adopted.Species}, she was first in line");
            adopted = shelter.Dequeue("dog");

            //Animal adopted2 = shelter.Dequeue("dog");
            //Console.WriteLine($"You have adopted {adopted2.Name}, which is a {adopted2.Species}");

            //Animal adopted3 = shelter.Dequeue("cat");
            //Console.WriteLine($"You have adopted {adopted3.Name}, which is a {adopted3.Species}");

        }
    }
}

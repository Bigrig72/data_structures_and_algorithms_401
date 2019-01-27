using System;
using Xunit;
using fifo_animal_shelter.classes;

namespace AnimalShelterTests
{
    public class UnitTest1
    {
        [Fact]
        public void ShowWeCanMakeAdog()
        {
            Dog dog = new Dog("nena");
            Assert.Equal("nena", dog.Name);
        }
        [Fact]
        public void ShowWeCanMakeAcat()
        {
            Cat cat= new Cat("Bear");
            Assert.Equal("Bear", cat.Name);
        }
       [Fact]
       public void ShowThatWeCanDequeue()
        {
            AnimalShelter shelter = new AnimalShelter();
            Dog bandit = new Dog("bandit");
            Dog jesus = new Dog("jesus");
            shelter.Enqueue(bandit);
            shelter.Enqueue(jesus);
            shelter.Dequeue("jesus");
            Assert.Equal("bandit", shelter.Primary.Front.Name);
        }
        [Fact]
        public void ShowThatWeCanDequeue2()
        {
            AnimalShelter shelter = new AnimalShelter();
            Dog brad = new Dog("brad");
            Dog dan = new Dog("dan");
            shelter.Enqueue(brad);
            shelter.Enqueue(dan);
            shelter.Dequeue("dan");
            Assert.Equal("brad", shelter.Primary.Front.Name);
        }
        [Fact]
        public void ShowThatWeCanEnqueue()
        {
            AnimalShelter shelter = new AnimalShelter();
            Dog brad = new Dog("brad");
          
            shelter.Enqueue(brad);
          
            Assert.Equal("brad", shelter.Primary.Front.Name);
        }
        [Fact]
        public void ShowThatWeCanEnqueue2()
        {
            AnimalShelter shelter = new AnimalShelter();
            Dog dan = new Dog("dan");

            shelter.Enqueue(dan);

            Assert.Equal("dan", shelter.Primary.Front.Name);
        }

    }
}

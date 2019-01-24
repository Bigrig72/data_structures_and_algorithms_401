## Challenge - Animal Shelter Queue

## What is the challenge?

Create a class called AnimalShelter which holds only dogs and cats. The shelter operates using a first-in, first-out approach.
Implement the following methods:

enqueue(animal): adds animal to the shelter. animal can be either a dog or a cat object.
dequeue(pref): returns either a dog or a cat. If pref is not "dog" or "cat" then return null.

queue 1& Queue2: Queue structures that hold Animals, passing one animal to the next
Primary: Ref to whichever Queue is acting as the primary at the time
Secondary: Ref to whichever Queue is acting as the helper at the time
Enqueue(): Adds a new animal to the shelter
Dequeue(type): Finds the first animal of specified type, removes it from the queue, re-combines the remainder of the queue (into secondary), switches Primary and seconday refs, and returns the selected animal Create a Queue class with the following properties and methods:
Top: Node object that references the stack's 'Top' node
Enqueue(Animal): Adds a passed-in Animal to the active queue, resets Rear to new Animal.
Dequeue(): Removes/returns the Animal at Front of queue, resets Front to next.
Peek(): Returns a reference to queue's Front for viewing. Create a Animal class with the following properties and methods:
Name: animal's name, set by derived class construtors
Species: Values set by derived class constructors
Next: next in line
Derived classes: Dog, Cat


## Time and space?
Time- O(n)
Space- O(n)

## Visual of Whiteboard

![whiteboard](https://github.com/Bigrig72/data_structures_and_algorithms_401/blob/master/Challenges/AnimalShelterQueue/assets/20190123_173826.jpg)

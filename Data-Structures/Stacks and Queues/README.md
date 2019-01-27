# Stacks and Queues

## What is a Stack
A stack is a data structure that consists of Nodes. Each Node references the next node in the stack, but does not reference it’s previous.

Common terminology for a stack is

Push - Nodes or items that are put into the stack are pushed
Pop - Nodes or items that are removed from the stack are popped
Top - This is the top of the stack.
Peek - When you Peek you will view the Top node in the stack. If the stack is empty, and you don’t Peek, you will receive a NullReferenceException if you attempt to Pop.
Stacks follow these concepts:

FILO concept: First In Last Out. This means that the first item in the stack, will be the last item out.

LIFO concept: Last In First Out This means that the last item in the stack, will be the first item out.

1. Push O(1) - BIG O
Pushing a node onto a stack will be an O(1) operation. This is because it takes the same amount of time, no matter how many 
nodes you have in the stack.When adding a node, you essentially want to Push it into the stack and then re-assign the Top to newly 
added node.
2. Pop O(1)- BIG O
Popping a node off a stack the action of removing a node from the top. When conducting a Pop, the Top node will be re-assigned 
to the node that lives below and the Top node is returned to the user.
3. Peek O(1)
When conducting a Peek, you will only be viewing the Top node of the stack. Traditionally, you always want to Peek before
conducting a Pop. This will ensure that you do not receive a NullExceptionError on your Pop action.

## What is a Queue
Common terminology for a queue is

1. Enqueue - Nodes or items that are added to the queue.
2. Dequeue - Nodes or items that are removed from the queue.
3. Front - This is the front/first node of the queue.
4. Rear - This is the rear/last node of the queue.
5. Peek - When you Peek you will view the Top node in the stack. If the stack is empty, and you don’t Peek, you will receive a NullReferenceException.

# Queues follow these concepts:

FIFO - First In First Out - This means that the first item in the queue will be the first item out of the queue.
LILO - Last In Last Out - This means that the last item in the queue will be the last item out of the queue.
## Challenge
Create a Node class that has properties for the value stored in the Node, and a pointer to the next node.
Create a Stack class that has a top property. It creates an empty Stack when instantiated.
This object should be aware of a default empty value assigned to top when the stack is created.
Define a method called push which takes any value as an argument and adds a new node with that value to the top of the stack with an O(1) Time performance.
Define a method called pop that does not take any argument, removes the node from the top of the stack, and returns the node’s value.
Define a method called peek that does not take an argument and returns the value of the node located on the top of the stack.
Create a Queue class that has a top property. It creates an empty queue when instantiated.
This object should be aware of a default empty value assigned to front when the queue is created.
Define a method called enqueue which takes any value as an argument and adds a new node with that value to the back of the queue with an O(1) Time performance.
Define a method called dequeue that does not take any argument, removes the node from the front of the queue, and returns the node’s value.
Define a method called peek that does not take an argument and returns the value of the node located in the front of the stack.
At no time should an exception or stack trace be shown to the end user. Catch and handle any such exceptions and return a printed value or operation which cleanly represents the state and either stops execution cleanly, or provides the user with clear direction and output.
Be sure to follow your languages best practices for naming conventions.

## Structure and Testing
Utilize the Single-responsibility principle: any methods you write should be clean, reusable, abstract component parts to the whole challenge. You will be given feedback and marked down if you attempt to define a large, complex algorithm in one function definition.

Write at least three test assertions for each method that you define.

Ensure your tests are passing before you submit your solution.
![test](https://github.com/Bigrig72/data_structures_and_algorithms_401/blob/master/Data-Structures/Stacks%20and%20Queues/assets/testing.PNG)


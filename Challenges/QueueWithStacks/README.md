# Implement a Queue using two Stacks.

## Challenge
Create a class, using two stack to simulate a que, which implements methods Enqueue and Dequeue. 

## Approach
Queues work by accepting new Nodes at the rear and ejecting them out of the front FIFO (first in and first out), they are indeed accessible 
at both ends compared to a stack which is not. Stacks can accept new values, eject values only from the top and peek the top value. We can simulate
a queue by exposing the inaccessible ends of the stack. We can simulate this queue by transfering all nodes into a single stack, where the top 
of the new stack is populated from the bottom of the previous stack. THe top will eventually be the rear for the que and the bottom of the other 
stack becomes the front. This is accomplished by using the Stack methods 'Pop' and 'Push':

## Example
## enqueue(value)
Input	Args	Output
[10]->[15]->[20]	5	[5]->[10]->[15]->[20]
 	5	[5]
  
## dequeue()
Input	Output	Internal State
[5]->[10]->[15]->[20]	20	[5]->[10]->[15])
[5]->[10]->[15]	15	[5]->[10]

## Classes Examples

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

## Queues follow these concepts:

FIFO - First In First Out - This means that the first item in the queue will be the first item out of the queue.
LILO - Last In Last Out - This means that the last item in the queue will be the last item out of the queue.

## Solution
![demo](https://github.com/Bigrig72/data_structures_and_algorithms_401/blob/master/Challenges/QueueWithStacks/assets/20190122_135558.jpg)

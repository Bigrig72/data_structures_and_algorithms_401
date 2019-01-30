## Challenge
Breadth-first Traversal.
Write a breadth first traversal method which takes a Binary Tree as its unique input.
Without utilizing any of the built-in methods available to your language, traverse the input 
tree using a Breadth-first approach; print every visited node’s value.

## Approach & Efficiency
A method called BreadthFirstTraversal will pass in a Node root and a List and return the values of the 
Binary Search Tree. We will first in this method create a new Queue and bring the type Node in. Next we will
enqueue the root of the tree being passed in which will bring the whole tree in. We will create a conditon
of while there is something in the Queue we will Dequeue and add that vallue to a refrence of current.
if current becomes null we continue and Enqueue current.left and current.right. When we do this we will add to the list and print.

Big O will be:
O(W) space for the width of tree.
O(n) time it will take to go through all of the nodes.

## Solution
![Whiteboard](https://github.com/Bigrig72/data_structures_and_algorithms_401/blob/master/Challenges/Breadth-First/BreadthFirst/Assets/20190130_110609.jpg
)

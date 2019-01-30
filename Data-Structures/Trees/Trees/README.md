# Code Challenge Trees

## Challenge

Create a Node class that has properties for the value stored in the node, the left child node, and the right child node.
Create a BinaryTree class and Define a method for each of the depth first traversals called preOrder, inOrder, and postOrder which
returns an array of the values, ordered appropriately.

Create a BinarySearchTree class
Define a method named add that accepts a value, and adds a new node with that value in the correct location in the binary search tree.
Define a method named contains that accepts a value, and returns a boolean indicating whether or not the value is in the tree at least once.

## API:

1. Add method - This method will search starting left on the tree, if there is no node there it will create another node
and it will keep moving left. This will also repeat for the right side.
2. Contains method - This will check if the root is null and if it is return false on that value. if root value
equals the value being passed in we will return true. If the root value is greater than the value being passed in we will recursively 
call contains and go left again to find a match, if no match it will recursively go right and look for match
3. Preorder
4. Postorder
5. Inorder



## Approach and Efficiency

Depth first is a traversal that traverses the depth (height) of the tree.

The different traversals determine at which point the Root is looked at. Here are the three different depth first traversals broken down:

Preorder
Root, Left, Right
Inorder
Left, Root, Right
Postorder
Left, Right, Root


Breadth First
The breadth first traversal iterates through the tree by going through each level of the tree node by node.
Traditionally the breadth first traversal leverages a queue to traverse the width (or the breadth) of the tree.

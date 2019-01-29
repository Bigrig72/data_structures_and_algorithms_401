# Code Challenge Trees

## Binary Tree and Binary Search Tree
Create a Node class that has properties for the value stored in the node, the left child node, and the right child node.
Create a BinaryTree class and Define a method for each of the depth first traversals called preOrder, inOrder, and postOrder which
returns an array of the values, ordered appropriately.

Create a BinarySearchTree class
Define a method named add that accepts a value, and adds a new node with that value in the correct location in the binary search tree.
Define a method named contains that accepts a value, and returns a boolean indicating whether or not the value is in the tree at least once.

## What is Depth first:

Depth first is a traversal that traverses the depth (height) of the tree.

The different traversals determine at which point the Root is looked at. Here are the three different depth first traversals broken down:

Preorder
Root, Left, Right
Inorder
Left, Root, Right
Postorder
Left, Right, Root

## What is Breadth First

Breadth First
The breadth first traversal iterates through the tree by going through each level of the tree node by node.
Traditionally the breadth first traversal leverages a queue to traverse the width (or the breadth) of the tree.

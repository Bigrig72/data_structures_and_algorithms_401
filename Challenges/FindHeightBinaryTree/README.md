## Challenge- Calculate the height of a binary tree 
Implement a method with the following signature int CalculateBinaryTreeHeight(Node root) that calculates the height of a binary tree.

Hint: The height of a binary tree is the height of its root

Stretch Goal (1 Additional Point)
Once you calculate the height of a tree, write a similar function to calculate the number of levels for a tree.

## What it looks like?
![demo](https://github.com/Bigrig72/data_structures_and_algorithms_401/blob/master/Challenges/FindHeightBinaryTree/FindHeightOfTree/Assets/Capture.PNG)

## Whiteboard Solotion
![whiteboard](https://github.com/Bigrig72/data_structures_and_algorithms_401/blob/master/Challenges/FindHeightBinaryTree/FindHeightOfTree/Assets/20190211_172102.jpg)

## Big O and Approach

# Finding the height of the tree
 O(H)- Resembles the height of the tree. We are looking for the total height by using recursion which will be O(H).
 Finding the height of the tree we will set two values to zero. We will set a leftSide and a Rightside. We will then recursively call the method to \
 check if root.left is not null if it isnt call the method and add 1 for each level is passes by. Do the same for the right. Agt the end we will 
 return whatever side is greatest using a turnary operation.
 # Finding the amount of levels of the tree including root level
 Here we will do something similar. We will recursively go left and right on the tree first after making sure the root is not null. If the Root i
 is null we will return 0. If it is not null go left and right recusiveley and we will run an if statement on if left is greater than right
 if so we will add 1 to the left and return or add one to the right and return to account for the root level.

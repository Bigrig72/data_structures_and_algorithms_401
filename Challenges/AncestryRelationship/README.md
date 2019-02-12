## Challenge- Determine if two values in a binary tree have an ancestry relationship.
Implement a method with the following signature bool IsAncestor(int A, int B, Node root) that returns true if the value A is an ancestor of the value B in the provided binary tree; the function will return false otherwise.

You can assume that the binary tree will have unique values.
A classical definition of ancestor nodes: “Any node present in the path from that node to the root node (including the root node)”

## Whiteboard Visual
![demo](https://github.com/Bigrig72/data_structures_and_algorithms_401/blob/master/Challenges/AncestryRelationship/AncestryRelationship/Assets/20190211_204655.jpg)

## Big O & Approach and Efficiency
Time and space for this challenge is O(n) - Worse case it has to traverse the left and right side therfore it is O(n).
With my approach we will recursively call our method after firstly setting a base case checking if the root is null, if so return false. 
We want to check all possible scenarios on the left to the right side. We will check to see if root.left and root.right == a and == b to both sides.
We want to check to see if on each level if there is a match with the nodes being passed in, which is A and B.






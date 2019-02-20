# Intersection of binary trees
This challenge will challenge the ability to use a data structure that will have to check two binary tress
and find what values are repeating in both trees. It is also noted that a Hash Table must be used.

## Challenge
Write a function called tree_intersection that takes two binary tree parameters.
Without utilizing any of the built-in library methods available to your language, return a set of values found in both trees.

## Approach & Efficiency
I approached this in a brute force way. I used a hash table for each tree and a outer for loop and an inner for loop.
After doing a preorder on my trees, my preorder is set up to put the tree in a list, aftwer doing so I hash all the values from tree 1.
Inner for loop will store the hash value for index J in a temp variable
Then we will run a check to see if the values match across trees and if so store in a new list

Time--O(n * m)
space--O(n)


## Solution
![demo](https://github.com/Bigrig72/data_structures_and_algorithms_401/blob/master/Challenges/TreeIntersection/TreeIntersectionHashTable/Assets/20190220_073137.jpg)

# Code Challenge: Fizz Buzz Tree

## Problem Domain
Conduct “FizzBuzz” on a tree while traversing through it. Change the values of each of the nodes dependent on the current node’s valu

## Implementation

Write a method called FizzBuzzTree which takes a tree as an argument. Determine weather or not the value of each node is divisible 
by 3, 5 or both, and change the value of each of the nodes:
If the value is divisible by 3, replace the value with “Fizz”
If the value is divisible by 5, replace the value with “Buzz”
If the value is divisible by 3 and 5, replace the value with “FizzBuzz”
Return the tree with its new values.

Utilizing my previous Binary tree that is built out and a node class that will accept a string as a value, I will recursively use
Pre-Order to check the left and right side of my tree. If any of those values meets the above condition I will then change that value with the 
appropriate string.

## Big O
Time- O(H)
Space- O(1)

## Whiteboard

![whiteboard](https://github.com/Bigrig72/data_structures_and_algorithms_401/blob/master/Challenges/Trees-FizzBuzz/FizzBuzzBinarfyTree/Assets/20190128_180041.jpg)

# First repeated word
This challenge will be a specific Hash Table or HAsh Map implemented challenge. We are searching a dictionary for the first
most occured word. Therefore, we use a hash table to check if each slot after the word is hashed contains multiple nodes with values.
If so we return that word. A hash Table will be the fastest way of doing so.

## Challenge
Write a function that accepts a lengthy string parameter.
Without utilizing any of the built-in library methods available to your language, return the first word 
to occur more than once in that provided string.

## Approach & Efficiency
This approach will be O(1), It is using a hash table and will find the key as the string is being iterated, it 
will then return as soon as finds the first duplicate.

## Solution
![whiteboard](https://github.com/Bigrig72/data_structures_and_algorithms_401/blob/master/Challenges/RepeatedWord/RepeatedWord/Assets/20190218_195155.jpg)

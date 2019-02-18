# Hashtables
A Hash-Table is a data structure that maps keys to values. Each position of the Hash-Table is
called a slot. The Hash-Table uses a hash function to calculate an index of an array of slots. We
use the Hash-Table when the number of keys actually stored is small relatively to the number of possible keys.

## Challenge
Implement a Hashtable with the following methods:

add: takes in both the key and value. This method should hash the key, and add the key and value pair to the table, handling collisions as needed.
get: takes in the key and returns the value from the table.
contains: takes in the key and returns a boolean, indicating if the key exists in the table already.
hash: takes in an arbitrary key and returns an index in the collection.

## Approach & Efficiency
We can directly go into that location and tell whether our object we are searching for is
present or not in just O(1) constant time.

## API
1. Hash Method
- It will provide a uniform distribution of hash values. A non-uniform distribution
increased the number of collisions and the cost of resolving them.
- It computes quickly and returns values within the range
of the Hash-Table.
- Handles collisions and has a good collision resolution algorithm which handles collision be creating a linked list and adding values to the listy.
- It will also have high load factor for a given set of keys.

2. Add Method
This method is created to find the index to which the key value will be stroed. Then it will add a value to the given index. 
If a collision occurs we will have a linked list to handle the issue.

3. Get
By using a find method from the linked list class, it is used to find that given key and return that givgen key.

4. Contains
Boolean set up to check to see if the value is contained in the given index. We will also use our Get method 
that will go and get the specific key, if it contains that key, return true.

# Testing

Adding a key/value to your hashtable results in the value being in the data structure
Retrieving based on a key returns the value stored
Successfully returns null for a key that does not exist in the hashtable
Successfully handle a collision within the hashtable
Successfully retrieve a value from a bucket within the hashtable that has a collision
Successfully hash a key to an in-range value

![testing](https://github.com/Bigrig72/data_structures_and_algorithms_401/blob/master/Data-Structures/HashMaps/HashTable/Assets/Capture.PNG)

# Lab 05: Linked Lists 

# What is being implemented with the Linked List?
We are building a linked list and the application will be able toprint the list, see if a node is included, insert a node into the list in the beginning, also insert at the end, which inserts the node at the end.

Insert (method): Instantiates and inserts a new node (of specified value) into the list, and points 'head' at it.
Includes (method): Checks list for the first node that contains the passed-in value
Print (method): Console prints the values of all nodes in the list
InsertBefore (method): Instantiates a new node (of specified value) and inserts into the list BEFORE an existing node. If no match exists, no node is inserted.
InsertAfter (method): Same as InsertBefore, except it inserts the new node AFTER the existing node (or none if no match);

# What it looks like?

![Demo](https://github.com/Bigrig72/data_structures_and_algorithms_401/blob/master/Challenges/LinkedList/assets/Capture.PNG)

# Approach and Effeciency? 

Linked list is considered as non-primitive data structure that contains a collection of unordered linked elements known as nodes. A linked list, you have to start from the head and work your way through until you get to the fourth element. Linked list takes linear time, so it is quite a bit slower. Operations like insertion and deletion in the common arrays consume a lot of time. On the other hand, the performance of these operations in Linked lists is fast.So Linked list provides the following two advantages
1) Dynamic size
2) Ease of insertion/deletion
3) Time complexity is O(1) (since it performs this set of operations just once regardless of the size of the linked list). Space complexity is O(1) since only a fixed amount of space is allocated (regardless of list size)

Linked lists have following drawbacks:
1) Random access is not allowed. We have to access elements sequentially starting from the first node. So we cannot do a binary search with linked lists.
2) Extra memory space for a pointer is required with each element of the list.

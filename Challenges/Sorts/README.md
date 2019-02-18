# Insertion Sort
A sorting algorithm like Insertion-Sort, Bubble-sort and Selection-Sort are easy to implement
and are suitable for the small input set. However, for large dataset they are slow.

## Challenge
Write a function for insertion sort that takes in an unsorted array and returns the array sorted using insertion sort.

## Approach & Efficiency
Insertion-Sort Time Complexity is O(n2) which is same as Bubble-Sort but performed a bit better
than it. It is the way we arrange our playing cards. We keep a sorted subarray. Each value is
inserted into its proper position in the sorted sub-array in the left of it.
Worst case Time Complexity O(n2)
Best case Time Complexity O(n)
Space Complexity O(1)

# API

Sort Method 

The outer loop is used to pick the value we want to insert into the sorted left array.
· The value we want to insert we have picked and saved in a temp variable.
· The inner loop is doing the comparison using the more() function. The values are shifted to
the right until we find the proper position of the temp value for which we are doing this
iteration.
· Finally the value is placed into the proper position.In each iteration of the outer loop, the
length of the sorted array increase by one. When we exit the outer loop the whole array is sorted.

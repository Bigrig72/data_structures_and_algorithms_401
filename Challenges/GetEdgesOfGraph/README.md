# Find Edges
Given a business trip itinerary, and an Alaska Airlines route map, is the trip possible with direct flights? 
If so, how much will the total trip cost be? 

We are looking to traverse a graph and check to see if the itinerary array being passed in to the method to be created
will show a direct flight.

## Challenge
Write a function based on the specifications above, which takes in a graph, and an array of city names. Without utilizing any of the 
built-in methods available to your language, return whether the full trip is possible with direct flights, and how much it would cost.

## Approach & Efficiency
The first step to the approach is creating a global variable called cost then iterating through the itinerary array (array.Length -1). 
Checking to see if the value in the array is contained, if it is not we return false with a weight of 0. In the list of vertices of the graph. 
If it does contain we want to do a linq query to check for that neighbor and find item2 which is the weight and add that to the total cost. 
We will return true with the total cost.

Big O-
space and time is - O(n)

## Solution
![demo](https://github.com/Bigrig72/data_structures_and_algorithms_401/blob/master/Challenges/GetEdgesOfGraph/GetEdges/Assets/20190227_101631.jpg)

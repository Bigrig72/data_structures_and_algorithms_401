# Breadth-First Traversal of a Graph
Breadth-first search is considered a more cautious algorithm. Rather than going deep, breadth-first search checks each path level-by-level, slowly reaching the depths of the graph.

## Challenge
Extend your graph object with a breadth-first traversal method that accepts a starting node. Without utilizing any of the built-in methods available to your language, return a collection of nodes in the order they were visited. Display the collection.

## Approach & Efficiency
Since all vertices can be reached by 1, all vertices are visited and returned by breadth-first search. Although the HashSet in C# doesn't guarantee an order, the order returned appears to be the exact path followed by breadth-first-search. Notice that breadth-first search cautiously checks each vertex level-by-level.

Start Level 0: 1
Traverse Level 1: 2, 3
Traverse Level 2: 4, 5, 6
Traverse Level 3: 7, 8
Traverse Level 4: 9, 10

To make sure the breadth-first search algorithm doesn't re-visit vertices, the visited HashSet keeps track of vertices already visited. A Queue, called queue, keeps track of vertices found but not yet visited. Initially queue contains the starting vertex. The next vertex is dequeued from queue. If it has already been visited, it is discarded and the next vertex is dequeued from queue. If it has not been visited, it is added to the set of visited vertices and its unvisited neighbors are added to queue. This continues until there are no more vertices in queue, and the set of vertices visited is returned. The set of vertices returned is all the vertices that can be reached from the starting vertex.

BIG O
time-O(n)
space-O(n)

## Solution
![demo](https://github.com/Bigrig72/data_structures_and_algorithms_401/blob/master/Challenges/Breadth-First-Graph/BreadthFirst/Assets/Capture.PNG)

# Graphs

Adjacency List is what is being implemented 
An adjacency list is the most common way to represent graphs. An adjacency list is a collection of linked lists or array
that lists all of the other vertices that are connected. Adjacency lists make it easy to view if one vertices connects to another.

## Challenge
Features
Implement your own Graph. The graph should be represented as an adjacency list, and should include the following methods:

1. AddNode()
-Adds a new node to the graph
2. Takes in the value of that node
-Returns the added node
3. AddEdge()
-Adds a new edge between two nodes in the graph
5. Include the ability to have a “weight”
6. Takes in the two nodes to be connected by the edge
-Both nodes should already be in the Graph
7. GetNodes()
8. Returns all of the nodes in the graph as a collection (set, list, or similar)
9. GetNeighbors()
-Returns a collection of nodes connected to the given node
10. Size()
-Returns the total number of nodes in the graph

## Approach & Efficiency
A Graph is an abstract data structure and can be modeled in various ways. Three popular ways to model a graph are 
1) edge list
2) adjacency matrix
3) adjacency list. 
I will be using an adjacency list. In the example, 
there are 3 vertices (1, 2, 3) in the graph. Vertex 1 has neighbors 2 and 3, vertex 2 has a single neighbor, 1, and vertex 3 also 
has a single neighbor. he adjacency list will be a Dictionary in C#, with the keys being the vertices and the value of each vertex 
being its set of neighbors.

Big-O
Space- O(1)- each method is a direct lookup or add for vertices
Time- O(1)- Using a hash set to access a value for neighbors, returning a whole list of values could be o(n) for traveling to each node.

## API

AddEdge()
AddVertex()
BuildGraph()
DFS()- Depth first traversal -To make sure the depth-first search algorithm doesn't re-visit vertices, the visited
HashSet keeps track of vertices already visited. A Stack, called stack, keeps track of vertices found but not yet visited. 
Initially stack contains the starting vertex. The next vertex is popped from stack. If it has already been visited, it is discarded 
and the next vertex is popped from stack. If it has not been visited, it is added to the set of visited vertices and its unvisited 
neighbors are added to stack. This continues until there are no more vertices in stack, and the set of vertices visited is returned.
The set of vertices returned is all the vertices that can be reached from the starting vertex.

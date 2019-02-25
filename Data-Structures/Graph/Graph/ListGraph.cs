using LinkedList.classes;
using System;
using System.Collections.Generic;

namespace Graph
{
    public class ListGraph
    {
        LinkedList<Tuple<int, int>>[] adjList;

        // Constructor that will create an empty adjacency list
        public ListGraph(int vertices)
        {
            adjList = new LinkedList<Tuple<int, int>>[vertices];

            for (int i = 0; i < adjList.Length; i++)
            {
                adjList[i] = new LinkedList<Tuple<int, int>>();
            }
        }

        // Appends a new edge to the linked list to the end
        public void addEdgeAtEnd(int startVertex, int endVertex, int weight)
        {
            adjList[startVertex].AddLast(new Tuple<int, int>(endVertex, weight));
        }

        // Appends a new edge to the linked list from front
        public void addEdgeAtBegin(int startVertex, int endVertex, int weight)
        {
            adjList[startVertex].AddFirst(new Tuple<int, int>(endVertex, weight));
        }

        // Returns number of vertices
        public int getNumberOfVertices()
        {
            return adjList.Length;
        }
        public LinkedList<Tuple<int, int>> this[int index]
        {
            get
            {
                LinkedList<Tuple<int, int>> edgeList = new LinkedList<Tuple<int, int>>(adjList[index]);

                return edgeList;
            }
        }
        public void printAdjList()
        {
            int i = 0;
            foreach (LinkedList<Tuple<int, int>> list in adjList)
            {
                Console.WriteLine("adjList[" + i + "] -> ");

                foreach (Tuple<int, int> edge in list)
                {
                    Console.WriteLine(edge.Item1 + "(" + edge.Item2 + ")");
                }
                i++;
                Console.WriteLine();
            }
        }

        public void ShowNeigh(Node v)
        {
            Dictionary<Node, bool> visited = new Dictionary<Node, bool>();
            Dictionary<Node, Node> result = new Dictionary<Node, Node>();

            Queue<Node> workList = new Queue<Node>();
            visited.Add(v, false);
        }


    }
}

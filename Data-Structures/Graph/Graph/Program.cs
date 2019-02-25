using LinkedList.classes;
using System;
using System.Collections.Generic;

namespace Graph
{
    public class Program
    {
        static void Main(string[] args)
        {
            int V = 4;

            ListGraph graph = new ListGraph(V);
            graph.addEdgeAtEnd(0, 1, 0);
            graph.addEdgeAtEnd(0, 4, 0);
            graph.addEdgeAtEnd(1, 2, 0);
            graph.addEdgeAtEnd(1, 3, 0);
            graph.addEdgeAtEnd(1, 4, 0);
            graph.addEdgeAtEnd(2, 3, 0);
            graph.addEdgeAtEnd(3, 4, 0);

            graph.printAdjList();







        }
    }
}

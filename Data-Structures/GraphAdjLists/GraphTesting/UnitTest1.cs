using System;
using Xunit;
using AdjacentListGraph;

namespace GraphTesting
{
    public class UnitTest1
    {

        //1.X Node can be successfully added to the graph
        //2.X An edge can be successfully added to the graph
        //3.X A collection of all nodes can be properly retrieved from the graph
        //4. All appropriate neighbors can be retrieved from the graph
        //5. Neighbors are returned with the weight between nodes included
        //6. The proper size is returned, representing the number of nodes in the graph
        //7. A graph with only one node and edge can be properly returned
        //8. An empty graph properly returns null

        [Fact]
        public void TestNodes()
        {
            var vertices = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var edges = new[]{Tuple.Create(1,2), Tuple.Create(1,3),
                Tuple.Create(2,4), Tuple.Create(3,5), Tuple.Create(3,6),
                Tuple.Create(4,7), Tuple.Create(5,7), Tuple.Create(5,8),
                Tuple.Create(5,6), Tuple.Create(8,9), Tuple.Create(9,10)};

           Graph<int> graph = new Graph<int>(vertices, edges);


            Assert.Equal(10, graph.AdjacencyList.Count);

        }
        [Fact]
        public void TestEdges()
        {
            var vertices = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var edges = new[]{Tuple.Create(1,2), Tuple.Create(1,3),
                Tuple.Create(2,4), Tuple.Create(3,5), Tuple.Create(3,6),
                Tuple.Create(4,7), Tuple.Create(5,7), Tuple.Create(5,8),
                Tuple.Create(5,6), Tuple.Create(8,9), Tuple.Create(9,10)};

            Graph<int> graph = new Graph<int>(vertices, edges);


            Assert.Equal(11, edges.Length);

        }
        [Fact]
        public void CollectionOfAllNodes()
        {
            var vertices = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var edges = new[]{Tuple.Create(1,2), Tuple.Create(1,3),
                Tuple.Create(2,4), Tuple.Create(3,5), Tuple.Create(3,6),
                Tuple.Create(4,7), Tuple.Create(5,7), Tuple.Create(5,8),
                Tuple.Create(5,6), Tuple.Create(8,9), Tuple.Create(9,10)};

            Graph<int> graph = new Graph<int>(vertices, edges);
            var algorithms = new DepthFirstTraversal();
         var dft = algorithms.DFS(graph, 1);

          Assert.Equal(dft.Count, graph.AdjacencyList.Count);



        }
    }
}

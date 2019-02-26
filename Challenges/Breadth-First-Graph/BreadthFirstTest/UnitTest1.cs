using AdjacentListGraph;
using System;
using Xunit;
using BreadthFirst;

namespace BreadthFirstTest
{
    public class UnitTest1
    {
        /// <summary>
        /// asserts that the breadth first traversal will keep my number 1 - 10 in order starting with Node 1
        /// </summary>
        [Fact]
        public void Test1()
        {
            var vertices = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var verticesResults = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var edges = new[]{Tuple.Create(1,2), Tuple.Create(1,3),
                Tuple.Create(2,4), Tuple.Create(3,5), Tuple.Create(3,6),
                Tuple.Create(4,7), Tuple.Create(5,7), Tuple.Create(5,8),
                Tuple.Create(5,6), Tuple.Create(8,9), Tuple.Create(9,10)};

            Graph<int> graph = new Graph<int>(vertices, edges);
            var algorithms = new BreadthFirstTraversal();
            var bft = algorithms.BFS(graph, 1);

            Assert.Equal(bft, verticesResults);

        }
    }
}

using System;
using Yu.DataStructure.NonGeneric;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Yu.DataStructure.NonGenericTest
{
    [TestClass]
    public class DijkstrasAlgorithmTest
    {
        [TestMethod]
        public void DAFindShortestPath()
        {
            var graph = new Graph("C:\\Users\\SCOTT\\Desktop\\159201\\Assignments\\6\\graph5.txt");
            DijkstrasAlgorithm.FindShortestPath(graph, 'A');
            Console.WriteLine();
            var graph2 = new Graph("C:\\Users\\SCOTT\\Desktop\\159201\\Assignments\\6\\graph1.txt");
            DijkstrasAlgorithm.FindShortestPath(graph2, 'A');
            Console.WriteLine();
            DijkstrasAlgorithm.FindShortestPath(graph, 'N');
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yu.DataStructure.NonGeneric;

namespace Yu.DataStructure.NonGenericTest
{
    [TestClass]
    public class GraphTest
    {
        [TestMethod]
        public void EdgeConstructor()
        {
            var edge = new Edge('A', 10);
        }

        [TestMethod]
        public void GraphConstructor()
        {
            var graph = new Graph();
        }

        [TestMethod]
        public void GraphAddNode()
        {
            var graph = new Graph();
            graph.AddNode('A');
            graph.AddNode('A');
            graph.AddNode('B');
            graph.Print();
        }

        [TestMethod]
        public void GraphAddEdge()
        {
            var graph = new Graph();
            graph.AddNode('A');
            graph.AddNode('B');
            graph.AddEdge('B', 'A', 10);
            graph.AddEdge('C', 'A', 10);
            graph.AddEdge('A', 'C', 10);
            graph.AddEdge('B', 'A', 10);
            graph.Print();
            graph.Print('A');
        }

        [TestMethod]
        public void GraphConstructorFromFile()
        {
            var graph = new Graph("C:\\Users\\SCOTT\\Desktop\\159201\\Assignments\\6\\graph5.txt");
            graph.Print();
        }
    }
}

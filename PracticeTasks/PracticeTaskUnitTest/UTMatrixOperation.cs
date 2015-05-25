using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YuGeneric;
using PracticeTasks;

namespace PracticeTaskUnitTest
{
    [TestClass]
    public class UTMatrixOperation
    {
        [TestMethod]
        public void MatrixNodeConstructor()
        {
            var node = new MatrixNode(10, 10, 10);
        }

        [TestMethod]
        public void MatrixNodeProperty()
        {
            var node = new MatrixNode(10, 11, 12);
            Assert.AreEqual(node.Value, 10);
            Assert.AreEqual(node.Row, 11);
            Assert.AreEqual(node.Col, 12);
        }

        [TestMethod]
        public void MatrixConstructor()
        {
            var matrix1 = new Matrix(6);
            var matrix2 = new Matrix("matrix1.txt");
        }

        [TestMethod]
        public void MatrixSize()
        {
            var matrix1 = new Matrix(6);
            var matrix2 = new Matrix("matrix1.txt");

            Assert.AreEqual(matrix1.Size, 6);
            Assert.AreEqual(matrix2.Size, 4);
        }

        [TestMethod]
        public void MatrixAddNode()
        {
            var matrix = new Matrix(4);
            matrix.AddNode(4, 4, 4);
        }

        [TestMethod]
        public void MatrixWriteMatrix()
        {
            var matrix = new Matrix("matrix1.txt");
            matrix.WriteMatrix("Matrix 1: ");
        }

        [TestMethod]
        public void MatrixAddMatrix()
        {
            var matrix1 = new Matrix("matrix1.txt");
            var matrix2 = new Matrix("matrix2.txt");

            var matrix3 = Matrix.AddMatrix(matrix1, matrix2);
            matrix1.WriteMatrix("Matrix 1: ");
            matrix2.WriteMatrix("Matrix 2: ");
            matrix3.WriteMatrix("Matrix Result: ");
        }
    }
}

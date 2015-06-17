using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yu.DataStructure.Generic;

namespace Yu.DataStructure.GenericTest
{
    [TestClass]
    public class UnitTestBinaryTree
    {
        [TestMethod]
        public void BinaryTreeNodeConstructor()
        {
            var node1 = new BinaryTreeNode<int>(0, null, null);
            var node2 = new BinaryTreeNode<string>("0", null, null);
        }

        [TestMethod]
        public void BinaryTreeNodeProperties()
        {
            var node1 = new BinaryTreeNode<int>(1, null, null);
            var node2 = new BinaryTreeNode<int>(2, null, null);
            var node0 = new BinaryTreeNode<int>(0, node1, node2);
            Assert.AreEqual(node1.Value, 1);
            Assert.ReferenceEquals(node2.Left, null);
            Assert.ReferenceEquals(node0.Right, node2);

            var node3 = new BinaryTreeNode<int>(3, null, null);
            var node4 = new BinaryTreeNode<int>(4, null, null);
            node1.Left = node3;
            node2.Right = node4;
            node4.Value = 5;
            Assert.ReferenceEquals(node1.Left, node3);
            Assert.AreEqual(node2.Right, node4);
            Assert.AreEqual(node4.Value, 5);
        }

        [TestMethod]
        public void BinaryTreeConstructor()
        {
            var tree0 = new BinaryTree<int>(0);
            var tree1 = new BinaryTree<int>(new BinaryTreeNode<int>(1, null, null));
        }

        [TestMethod]
        public void BinaryTreeRoot()
        {
            var node1 = new BinaryTreeNode<int>(1);
            var node2 = new BinaryTreeNode<int>(2);
            var node0 = new BinaryTreeNode<int>(0, node1, node2);
            var tree0 = new BinaryTree<int>(node0);
            Assert.AreEqual(tree0.Root.Value, 0);
        }

        [TestMethod]
        public void BinaryTreeInOrder()
        {
            var node5 = new BinaryTreeNode<int>(5);
            var node4 = new BinaryTreeNode<int>(4);
            var node3 = new BinaryTreeNode<int>(3);
            var node2 = new BinaryTreeNode<int>(2, node5, null);
            var node1 = new BinaryTreeNode<int>(1, node3, node4);
            var node0 = new BinaryTreeNode<int>(0, node1, node2);

            BinaryTree<int>.InOrder(node0);
        }

        [TestMethod]
        public void BinaryTreePreOrder()
        {
            var node5 = new BinaryTreeNode<int>(5);
            var node4 = new BinaryTreeNode<int>(4);
            var node3 = new BinaryTreeNode<int>(3);
            var node2 = new BinaryTreeNode<int>(2, node5, null);
            var node1 = new BinaryTreeNode<int>(1, node3, node4);
            var node0 = new BinaryTreeNode<int>(0, node1, node2);

            BinaryTree<int>.PreOrder(node0);
        }

        [TestMethod]
        public void BinaryTreePostOrder()
        {
            var node5 = new BinaryTreeNode<int>(5);
            var node4 = new BinaryTreeNode<int>(4);
            var node3 = new BinaryTreeNode<int>(3);
            var node2 = new BinaryTreeNode<int>(2, node5, null);
            var node1 = new BinaryTreeNode<int>(1, node3, node4);
            var node0 = new BinaryTreeNode<int>(0, node1, node2);

            BinaryTree<int>.PostOrder(node0);
        }

        [TestMethod]
        public void BinaryTreePreOrderWithStack()
        {
            var node5 = new BinaryTreeNode<int>(5);
            var node4 = new BinaryTreeNode<int>(4);
            var node3 = new BinaryTreeNode<int>(3);
            var node2 = new BinaryTreeNode<int>(2, node5, null);
            var node1 = new BinaryTreeNode<int>(1, node3, node4);
            var node0 = new BinaryTreeNode<int>(0, node1, node2);

            BinaryTree<int>.PreOrderWithStack(node0);
        }

        [TestMethod]
        public void BinaryTreeInOrderWithStack()
        {
            var node5 = new BinaryTreeNode<int>(5);
            var node4 = new BinaryTreeNode<int>(4);
            var node3 = new BinaryTreeNode<int>(3);
            var node2 = new BinaryTreeNode<int>(2, node5, null);
            var node1 = new BinaryTreeNode<int>(1, node3, node4);
            var node0 = new BinaryTreeNode<int>(0, node1, node2);

            BinaryTree<int>.InOrderWithStack(node0);
        }

        [TestMethod]
        public void BinaryTreePostOrderWithStack()
        {
            var node5 = new BinaryTreeNode<int>(5);
            var node4 = new BinaryTreeNode<int>(4);
            var node3 = new BinaryTreeNode<int>(3);
            var node2 = new BinaryTreeNode<int>(2, node5, null);
            var node1 = new BinaryTreeNode<int>(1, node3, node4);
            var node0 = new BinaryTreeNode<int>(0, node1, node2);

            BinaryTree<int>.PostOrderWithStack(node0);
        }

        [TestMethod]
        public void BinaryTreeBreadthFirst()
        {
            var node5 = new BinaryTreeNode<int>(5);
            var node4 = new BinaryTreeNode<int>(4);
            var node3 = new BinaryTreeNode<int>(3);
            var node2 = new BinaryTreeNode<int>(2, node5, null);
            var node1 = new BinaryTreeNode<int>(1, node3, node4);
            var node0 = new BinaryTreeNode<int>(0, node1, node2);

            BinaryTree<int>.BreadthFirstTraversal(node0);
        }
    }
}

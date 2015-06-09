using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YuGeneric;

namespace UnitTestYuGeneric
{
    [TestClass]
    public class UnitTestBinarySearchTree
    {
        public void MakeTree(TreeNodeInt root)
        {
            BinarySearchTree.Insert(root, 4);
            BinarySearchTree.Insert(root, 8);
            BinarySearchTree.Insert(root, 20);
            BinarySearchTree.Insert(root, 12);
            BinarySearchTree.Insert(root, 3);
            BinarySearchTree.Insert(root, 7);
            BinarySearchTree.Insert(root, 17);
        }

        [TestMethod]
        public void BSTInsert()
        {
            var root = new TreeNodeInt(10, null, null);
            BinarySearchTree.Insert(root, 8);
            BinarySearchTree.Insert(root, 20);
            BinarySearchTree.Insert(root, 10);
        }

        [TestMethod]
        public void BSTInOrder()
        {
            var root = new TreeNodeInt(10, null, null);
            MakeTree(root);
            BinarySearchTree.InOrderPrint(root);
        }

        [TestMethod]
        public void BSTSearch()
        {
            var root = new TreeNodeInt(10, null, null);
            MakeTree(root);
            Assert.AreEqual(BinarySearchTree.Search(root, 12).Value, 12);
            Assert.AreEqual(BinarySearchTree.Search(root, 10).Value, 10);
            Assert.ReferenceEquals(BinarySearchTree.Search(root, 222), null);
        }

        [TestMethod]
        public void BSTSearchRecursive()
        {
            var root = new TreeNodeInt(10, null, null);
            MakeTree(root);
            Assert.AreEqual(BinarySearchTree.SearchRecursive(root, 12).Value, 12);
            Assert.AreEqual(BinarySearchTree.SearchRecursive(root, 10).Value, 10);
            Assert.ReferenceEquals(BinarySearchTree.SearchRecursive(root, 222), null);
        }

        [TestMethod]
        public void BSTInsertNonRecursive()
        {
            var root = new TreeNodeInt(10, null, null);
            BinarySearchTree.InsertNonRecursive(root, 12);
            BinarySearchTree.InsertNonRecursive(root, 20);
            BinarySearchTree.InsertNonRecursive(root, 5);
            BinarySearchTree.InsertNonRecursive(root, 10);
            BinarySearchTree.InOrderPrint(root);
        }

        [TestMethod]
        public void BSTDelete()
        {
            var root = new TreeNodeInt(10, null, null);
            MakeTree(root);
            BinarySearchTree.Delete(ref root, 4);
            Assert.AreEqual(root.Left.Value, 7);
            BinarySearchTree.Insert(root, 40);
            BinarySearchTree.Insert(root, 30);
            BinarySearchTree.Insert(root, 50);
            BinarySearchTree.Insert(root, 35);
            BinarySearchTree.Delete(ref root, 40);
            Assert.AreEqual(BinarySearchTree.Search(root, 35).Left.Value, 30);
            Assert.AreEqual(BinarySearchTree.Search(root, 35).Right.Value, 50);
            Assert.ReferenceEquals(BinarySearchTree.Search(root,20).Right, BinarySearchTree.Search(root, 35));
        }

    }
}

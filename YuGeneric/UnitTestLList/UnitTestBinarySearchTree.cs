using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YuGeneric;

namespace UnitTestYuGeneric
{
    [TestClass]
    public class UnitTestBinarySearchTree
    {
        [TestMethod]
        public void BSTInsert()
        {
            var root = new TreeNodeInt(10, null, null);
            BinarySearchTree.Insert(root, 8);
            BinarySearchTree.Insert(root,20);
            BinarySearchTree.Insert(root,10);
        }

        [TestMethod]
        public void BSTInOrder()
        {
            var root = new TreeNodeInt(10, null, null);
            BinarySearchTree.Insert(root, 8);
            BinarySearchTree.Insert(root, 20);
            BinarySearchTree.Insert(root, 10);
            BinarySearchTree.InOrderPrint(root);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YuGeneric;

namespace UnitTestYuGeneric
{
    [TestClass]
    public class UnitTestQueue
    {
        [TestMethod]
        public void QueueNodeConstructor()
        {
            var node1 = new QueueNode<int>();
            var node2 = new QueueNode<string>("aaa");
        }

        [TestMethod]
        public void QueueNodeProperty()
        {
            var node = new QueueNode<string>("bbb");
            Assert.AreEqual(node.Value, "bbb");
            Assert.ReferenceEquals(node.Next, null);

            var node2 = new QueueNode<string>("ccc");
            node2.Next = node;
            Assert.ReferenceEquals(node2.Next, node);
        }

        [TestMethod]
        public void QueueConstructor()
        {
            var qInt = new Queue<int>();
            var qString = new Queue<string>();
        }

        [TestMethod]
        public void QueueProperty()
        {
            var queue = new Queue<int>();
            Assert.ReferenceEquals(queue.Front, null);

            queue.Join(10);
            Assert.AreEqual(queue.Front.Value, 10);

            queue.Join(20);
            Assert.AreEqual(queue.Front.Value, 20);
        }

        [TestMethod]
        public void QueueCount()
        {
            var queue = new Queue<int>();
            Assert.AreEqual(queue.Count(), 0);

            queue.Join(0);
            Assert.AreEqual(queue.Count(), 1);

            for (int i = 0; i < 10; i++)
            {
                queue.Join(i);
            }
            Assert.AreEqual(queue.Count(), 11);
        }

        [TestMethod]
        public void QueueIsEmpty()
        {
            var queue = new Queue<int>();
            Assert.AreEqual(queue.IsEmpty(), true);
            queue.Join(10);
            Assert.AreEqual(queue.IsEmpty(), false);
        }

        [TestMethod]
        public void QueueJoin()
        {
            var queue = new Queue<int>();
            queue.Join(new QueueNode<int>(10));
            Assert.AreEqual(queue.Front.Value, 10);
            queue.Join(100);
            Assert.AreEqual(queue.Front.Value, 100);
            Assert.AreEqual(queue.Count(), 2);
        }

        [TestMethod]
        public void QueueLeave()
        {
            var queue = new Queue<int>();
            Assert.AreEqual(queue.Leave(), false);
            queue.Join(10);
            Assert.AreEqual(queue.Leave(), true);
            Assert.AreEqual(queue.IsEmpty(), true);
            queue.Join(20);
            queue.Join(30);
            Assert.AreEqual(queue.Leave(), true);
            Assert.AreEqual(queue.Count(), 1);
            Assert.AreEqual(queue.Front.Value, 20);
        }
    }
}

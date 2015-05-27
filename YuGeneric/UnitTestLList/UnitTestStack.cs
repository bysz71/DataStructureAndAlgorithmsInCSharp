using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YuGeneric;

namespace UnitTestYuGeneric
{
    [TestClass]
    public class UnitTestStack
    {
        [TestMethod]
        public void StackNodeConstructor()
        {
            var node1 = new StackNode<int>();
            var node2 = new StackNode<string>();

            var node3 = new StackNode<int>(10);
            var node4 = new StackNode<string>("aaa");
        }

        [TestMethod]
        public void StackNodeProperty()
        {
            var node1 = new StackNode<int>(10);
            Assert.AreEqual(node1.Value, 10);
            Assert.ReferenceEquals(node1.Next, null);
        }

        [TestMethod]
        public void StackConstructor()
        {
            var stack = new Stack<int>();
            var stack2 = new Stack<string>();
        }

        [TestMethod]
        public void StackTop()
        {
            var stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            Assert.AreEqual(stack.Top.Value, 20);
            stack.Top.Value = 30;
            Assert.AreEqual(stack.Top.Value, 30);
        }

        [TestMethod]
        public void StackPush()
        {
            var stack = new Stack<int>();
            stack.Push(10);
            stack.Push(10);
            var node = new StackNode<int>(100);
            stack.Push(node);
        }

        [TestMethod]
        public void StackPop()
        {
            var stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Pop();
            Assert.AreEqual(stack.Top.Value, 10);
        }

        [TestMethod]
        public void StackIsEmpty()
        {
            var stack = new Stack<int>();
            Assert.AreEqual(stack.IsEmpty(), true);
            stack.Push(10);
            Assert.AreEqual(stack.IsEmpty(), false);
        }
    }
}

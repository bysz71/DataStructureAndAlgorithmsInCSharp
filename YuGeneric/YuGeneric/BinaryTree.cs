using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yu.DataStructure.Generic
{
    public class BinaryTreeNode<T>
    {
        private T _value;
        private BinaryTreeNode<T> _left;
        private BinaryTreeNode<T> _right;

        public BinaryTreeNode(T value)
        {
            _value = value;
            _left = null;
            _right = null;
        }

        public BinaryTreeNode(T value, BinaryTreeNode<T> left, BinaryTreeNode<T> right)
        {
            _value = value;
            _left = left;
            _right = right;
        }

        public T Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }

        public BinaryTreeNode<T> Left
        {
            get
            {
                return _left;
            }
            set
            {
                _left = value;
            }
        }

        public BinaryTreeNode<T> Right
        {
            get
            {
                return _right;
            }
            set
            {
                _right = value;
            }
        }
    }
    
    public class BinaryTree<T>
    {
        private BinaryTreeNode<T> _root;

        public BinaryTree(BinaryTreeNode<T> root)
        {
            _root = root;
        }

        public BinaryTree(T rootValue)
        {
            _root = new BinaryTreeNode<T>(rootValue, null, null);
        }

        public BinaryTreeNode<T> Root
        {
            get
            {
                return _root;
            }
            set
            {
                _root = value;
            }
        }

        public static void InOrder(BinaryTreeNode<T> node){
            if (node == null) return;
            InOrder(node.Left);
            Console.Write(node.Value + " ");
            InOrder(node.Right);
        }

        public static void PreOrder(BinaryTreeNode<T> node)
        {
            if (node == null) return;
            Console.Write(node.Value + " ");
            PreOrder(node.Left);
            PreOrder(node.Right);
        }

        public static void PostOrder(BinaryTreeNode<T> node)
        {
            if (node == null) return;
            PostOrder(node.Left);
            PostOrder(node.Right);
            Console.Write(node.Value + " ");
        }

        public static void PreOrderWithStack(BinaryTreeNode<T> node)
        {
            Stack<BinaryTreeNode<T>> stack = new Stack<BinaryTreeNode<T>>();
            BinaryTreeNode<T> temp = node;
            if (temp != null) stack.Push(temp);

            while (!stack.IsEmpty())
            {
                temp = stack.Top.Value;
                stack.Pop();
                Console.Write(temp.Value + " ");
                if (temp.Right != null)
                {
                    stack.Push(temp.Right);
                }
                if (temp.Left != null)
                {
                    stack.Push(temp.Left);
                }
            }
            Console.WriteLine();
        }

        /// <summary>
        /// "One Fish Bone At A Loop", it deals one "fishbone" at a loop--
        /// a fish bone is a structure from top to most left child--
        /// the fish bone is pushed follow the order "RightChild->Mother->RightChild->Mother"--
        /// once a fish bone is finished, temp pointer will move to the latest right child||
        /// structure:
        /// outer loop{
        /// --inner loop1, stack stores up to most left child, temp to null
        /// --temp buffers Top and Pop it;
        /// --inner loop2, back track to latest node with right child, temp buffers the node, Top holds the right child
        /// --print the node,
        /// --if stack not empty, move temp pointer to the right child, start next outer loop
        /// --if stack is empty(node reaches root, with no right child), temp points null
        /// }
        /// </summary>
        /// <param name="node"></param>
        public static void InOrderWithStack(BinaryTreeNode<T> node)
        {
            var s = new Stack<BinaryTreeNode<T>>();
            var temp = node;
            while (temp != null)
            {
                while (temp != null)
                {
                    if (temp.Right != null) {
                        s.Push(temp.Right);
                    }
                    s.Push(temp);
                    temp = temp.Left;
                }

                temp = s.Top.Value;
                s.Pop();

                while (!s.IsEmpty() && temp.Right == null)
                {
                    Console.Write(temp.Value + " ");
                    temp = s.Top.Value;
                    s.Pop();
                }

                Console.Write(temp.Value + " ");

                if (!s.IsEmpty())
                {
                    temp = s.Top.Value;
                    s.Pop();
                }
                else
                {
                    temp = null;
                }
            }
        }


        public static void PostOrderWithStack(BinaryTreeNode<T> node){
            var s = new Stack<BinaryTreeNode<T>>();
            var curr = node;
            var prev = node;

            while (curr != null)
            {
                while (curr.Left != null)
                {
                    s.Push(curr);
                    curr = curr.Left;
                }

                while (curr.Right == null || curr.Right == prev)
                {
                    Console.Write(curr.Value + " ");
                    prev = curr;
                    if (s.IsEmpty()) return;
                    curr = s.Top.Value;
                    s.Pop();
                }

                s.Push(curr);
                curr = curr.Right;
            }
            Console.WriteLine();
        }

        /// <summary>
        /// 1.Firstly Join the root to queue, then start looping;
        /// 2.In loop, Buffer the queue Front, Leave it from queue, if it has child, join into queue, from left to right;
        /// 3.Break loop when queue is empty;
        /// Join items that need to priorly handled to the queue, based on queue's FIFO feature
        /// It will iterate through the tree top to down level by level
        /// </summary>
        /// <param name="root"></param>
        public static void BreadthFirstTraversal(BinaryTreeNode<T> root)
        {
            var q = new Queue<BinaryTreeNode<T>>();
            var temp = root;
            if (temp != null)
            {
                q.Join(temp);
                while (!q.IsEmpty())
                {
                    temp = q.Front.Value;
                    q.Leave();
                    Console.Write(temp.Value + " ");
                    if (temp.Left != null)
                        q.Join(temp.Left);
                    if (temp.Right != null)
                        q.Join(temp.Right);
                }
                Console.WriteLine();
            }
        }
    }
}

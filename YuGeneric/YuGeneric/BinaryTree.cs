using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YuGeneric
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

        public static void InOrderWithStack(BinaryTreeNode<T> node)
        {
            var s = new Stack<BinaryTreeNode<T>>();
            var temp = node;
            while (temp != null)
            {
                while (temp != null)
                {
                    //--for 1st turn, temp is the root
                    //--for rest turns, temp was the right child from last turn
                    //--now seen as a sub root
                    //--if it has childs, push right child first
                    //--then himself back to stack
                    //--repeatly do this until reach most left child in this branch
                    if (temp.Right != null) {
                        s.Push(temp.Right);
                    }
                    s.Push(temp);
                    temp = temp.Left;
                }

                //Pop a node from the stack, hold on temp
                temp = s.Top.Value;
                s.Pop();

                //print temp, update temp to a new poped node
                //untill reach a node with right child
                //temp hold this node, stack Top hold its right child
                while (!s.IsEmpty() && temp.Right == null)
                {
                    Console.Write(temp.Value + " ");
                    temp = s.Top.Value;
                    s.Pop();
                }

                //print that node
                Console.Write(temp.Value + " ");

                //pop the right child node from the stack and give to temp
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
    }
}

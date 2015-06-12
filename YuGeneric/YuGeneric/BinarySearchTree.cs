using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yu.DataStructure.Generic
{
    public class BinarySearchTree
    {
        /// <summary>
        /// Insert an int to a binary search tree
        /// It uses recursive to implement insertion
        /// It always add a new node to a leaf
        /// It never breaks a existed connection to break itself in
        /// </summary>
        /// <param name="root">the root node of the BST</param>
        /// <param name="item">the int that will be inserted</param>
        public static void Insert(TreeNodeInt root, int item)
        {
            if (item > root.Value)
            {
                if (root.Right == null)
                {
                    root.Right = new TreeNodeInt(item, null, null);
                }
                else
                {
                    Insert(root.Right, item);
                }
            }
            else if (item < root.Value)
            {
                if (root.Left == null)
                {
                    root.Left = new TreeNodeInt(item, null, null);
                }
                else
                {
                    Insert(root.Left, item);
                }
            }
            else
            {
                Console.WriteLine("Error: key is no unique");
                return;
            }
        }

        /// <summary>
        /// Just print out the tree use InOrder traversal
        /// </summary>
        /// <param name="root">tree root node</param>
        public static void InOrderPrint(TreeNodeInt root)
        {
            if (root == null) return;
            InOrderPrint(root.Left);
            Console.Write(root.Value + " ");
            InOrderPrint(root.Right);
        }

        /// <summary>
        /// Search a specific value in a BST
        /// Concept is kinda similar to Insert()
        /// But not using recursive way
        /// Which recursive can be used I think
        /// I'll write a recursive search
        /// </summary>
        /// <param name="root">tree root node</param>
        /// <param name="value">search key value</param>
        /// <returns></returns>
        public static TreeNodeInt Search(TreeNodeInt root, int value)
        {
            var current = root;
            while (current != null)
            {
                if (current.Value == value)
                {
                    Console.WriteLine("Found {0}", value);
                    return current;
                }
                else if (value < current.Value)
                {
                    current = current.Left;
                }
                else if (value > current.Value)
                {
                    current = current.Right;
                }
            }
            Console.WriteLine("{0} is not found in the tree", value);
            return null;
        }

        /// <summary>
        /// Use recursive way to search a value
        /// So yes recursive way can be used in here
        /// Just same as insert
        /// so insert() can be rewritten in non-recursive way I think
        /// </summary>
        /// <param name="root"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static TreeNodeInt SearchRecursive(TreeNodeInt root, int value)
        {
            var current = root;
            if (value == current.Value)
            {
                Console.WriteLine(value + " Found");
            }else if (value < current.Value)
            {
                if (current.Left == null) current = null;
                else current = SearchRecursive(current.Left, value);
            }
            else if (value > current.Value)
            {
                if (current.Right == null) current = null;
                else current = SearchRecursive(current.Right, value);
            }

            if (current == null) Console.WriteLine(value + " not found in the BST");
            return current;
        }

        /// <summary>
        /// Insert a value using non-recursive way
        /// So yeah, using loop can acheive insertion
        /// </summary>
        /// <param name="root"></param>
        /// <param name="value"></param>
        public static void InsertNonRecursive(TreeNodeInt root, int value)
        {
            var current = root;
            while (current != null)
            {
                if (value == current.Value)
                {
                    Console.WriteLine("Error: Un-Unique key not permitted.");
                    return;
                }

                if (value < current.Value)
                {
                    if (current.Left == null)
                    {
                        current.Left = new TreeNodeInt(value, null, null);
                        Console.WriteLine(value + " added");
                        return;
                    }
                    else
                    {
                        current = current.Left;
                        continue;
                    }
                }

                if (value > current.Value)
                {
                    if (current.Right == null)
                    {
                        current.Right = new TreeNodeInt(value, null, null);
                        Console.WriteLine(value + " added");
                        return;
                    }
                    else
                    {
                        current = current.Right;
                        continue;
                    }
                }                        
            }
        }

        /// <summary>
        /// Delete a node when it is a leaf
        /// A method serves Delete()
        /// </summary>
        /// <param name="root"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        private static bool DeleteLeaf(ref TreeNodeInt root, int value)
        {
            var current = root;
            if (root.Value == value)
            {
                Console.WriteLine("Error: You cannot delete the root of a one node tree");
                return false;
            }
            var mother = FindMother(root, value);
            if (value == mother.Left.Value)
            {
                mother.Left = null;
                return true;
            }
            else
            {
                mother.Right = null;
                return true;
            }
        }

        /// <summary>
        /// Delete a node when it has 1 child
        /// A method serves Delete()
        /// </summary>
        /// <param name="root"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        private static bool DeleteSingle(ref TreeNodeInt root, int value)
        {
            var current = root;
            
            if (root.Value == value)
            {
                if (root.Left != null)  root = root.Left;
                else root = root.Right;
                return true;
            }

            var mother = FindMother(root, value);
            if (mother.Left.Value == value)
            {
                if (mother.Left.Left != null) mother.Left = mother.Left.Left;
                else mother.Left = mother.Left.Right;
            }
            else
            {
                if (mother.Right.Left != null) mother.Right = mother.Right.Left;
                else mother.Right = mother.Right.Right;
            }
            return true;
        }

        /// <summary>
        /// A mothod serves Delete()
        /// Delete a node when it has 2 children
        /// </summary>
        /// <param name="root"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        private static bool DeleteDouble(ref TreeNodeInt root, int value)
        {
            if (root.Value == value)
            {
                if (GetHeight(root.Left) > GetHeight(root.Right))
                {
                    root = FindLeftLargest(root);
                }
                else
                {
                    root = FindRightSmallest(root);
                }
                return true;
            }

            var mother = FindMother(root, value);
            if (mother.Left.Value == value)
            {
                if (GetHeight(mother.Left.Left) > GetHeight(mother.Left.Right))
                {
                    mother.Left = FindLeftLargest(mother.Left);
                    Console.WriteLine("FindLeftLargest");
                }
                else
                {
                    mother.Left = FindRightSmallest(mother.Left);
                    Console.WriteLine("FindRightLargest");
                }
            }
            else
            {
                if (GetHeight(mother.Right.Left) > GetHeight(mother.Right.Right))
                {
                    mother.Right = FindLeftLargest(mother.Right);
                    Console.WriteLine("FindLeftLargest");
                }
                else
                {
                    mother.Right = FindLeftLargest(mother.Right);
                    Console.WriteLine("FindRightLargest");
                }
            }
            return true;
        }

        /// <summary>
        /// A method serves Delete()
        /// Find left largest node, break its original connections, put it on top
        /// </summary>
        /// <param name="root"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        private static TreeNodeInt FindLeftLargest(TreeNodeInt node)
        {
            var current = node.Left;
            var prev = current;
            if (current.Right == null)
            {
                current.Right = node.Right;
            }
            else
            {
                while (current.Right != null)
                {
                    prev = current;
                    current = current.Right;
                }
                //2 cases
                //1, left largest node has no child
                if (current.Left == null)
                {
                    prev.Right = null;
                    current.Left = node.Left;
                    current.Right = node.Right;
                }
                //2, left largest node has node (a left child)
                else
                {
                    prev.Right = current.Left;
                    current.Left = node.Left;
                    current.Right = node.Right;
                }
            }
            return current;
        }

        private static int GetHeight(TreeNodeInt node)
        {
            if (node.Left == null && node.Right == null)
            {
                return 1;
            }
            else
            {
                if (node.Left == null)
                {
                    return GetHeight(node.Right) + 1;
                }
                else if (node.Right == null)
                {
                    return GetHeight(node.Left) + 1;
                }
                else
                {
                    if (GetHeight(node.Left) >= GetHeight(node.Right))
                    {
                        return GetHeight(node.Left) + 1;
                    }
                    else
                    {
                        return GetHeight(node.Right) + 1;
                    }
                }
            }
        }

        /// <summary>
        /// A method serves Delete()
        /// Find right smallest node, break its original connections, put it on top
        /// </summary>
        /// <param name="root"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        private static TreeNodeInt FindRightSmallest(TreeNodeInt node)
        {
            var current = node.Right;
            var prev = current;
            if (current.Left == null)
            {
                current.Left = node.Left;
            }
            else
            {
                while (current.Left != null)
                {
                    prev = current;
                    current = current.Left;
                }
                if (current.Right == null)
                {
                    prev.Left = null;
                    current.Left = node.Left;
                    current.Right = node.Right;
                }
                else
                {
                    prev.Left = current.Right;
                    current.Left = node.Left;
                    current.Right = node.Right;
                }
            }
            return current;
        }

        /// <summary>
        /// Find wanted value's mother node
        /// A method serves Delete()
        /// </summary>
        /// <param name="root"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        private static TreeNodeInt FindMother(TreeNodeInt root, int value)
        {
            var current = root;
            while (true)
            {
                if (current.Left.Value == value || current.Right.Value == value)
                {
                    return current;
                }
                else
                {
                    if (value < current.Value)
                    {
                        current = current.Left;
                    }
                    else
                    {
                        current = current.Right;
                    }
                }
            }
        }

        /// <summary>
        /// Only open socket of delete
        /// delete action depend on 3 different cases
        /// 1.node has no child
        /// 2.node has 1 child
        /// 3.node has 2 children
        /// 1st case is straight forward
        /// 2st case use the child to replace itself
        /// 3st case use the Left Largest node or Right Smallest node to replace itself depend on balance status
        /// </summary>
        /// <param name="root">root node of a tree, use "ref" keyword</param>
        /// <param name="value">the node you want to delete has this value</param>
        /// <returns></returns>
        public static bool Delete(ref TreeNodeInt root, int value)
        {
            var search = Search(root, value);
            var current = root;

            if (search == null)
            {
                Console.WriteLine("No such item in the tree");
                return false;
            }
            
            if (search.Left == null && search.Right == null)
            {
                return DeleteLeaf(ref root, value);
            }
            else if (search.Left == null || search.Right == null)
            {
                return DeleteSingle(ref root, value);
            }
            else
            {
                return DeleteDouble(ref root, value);
            }
        }
    }

    /// <summary>
    /// a binary search tree node type, its value is an integer
    /// did not use generic types to make the program easier
    /// also because I don't know how to compare generic types
    /// </summary>
    public class TreeNodeInt
    {
        public int Value;
        public TreeNodeInt Left;
        public TreeNodeInt Right;

        public TreeNodeInt(int value, TreeNodeInt left, TreeNodeInt right)
        {
            Value = value;
            Left = left;
            Right = right;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YuGeneric
{
    public class BinarySearchTree
    {
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

        public static void InOrderPrint(TreeNodeInt root)
        {
            if (root == null) return;
            InOrderPrint(root.Left);
            Console.Write(root.Value + " ");
            InOrderPrint(root.Right);
        }
    }

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

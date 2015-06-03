using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YuGeneric;

namespace PracticeTasks
{
    public class RPNTree
    {
        private static char[] optrs = { '+', '-', '*', '/' };

        public static RPNTreeNode RPNToTree(string expression)
        {
            RPNTreeNode t1, t2;
            var s = new Stack<RPNTreeNode>();
            char[] exps = expression.ToCharArray();
            for (int i = 0; i < exps.Length; i++)
            {
                if (Char.IsNumber(exps[i]))
                {
                    s.Push(new RPNTreeNode(exps[i],null,null));
                    continue;
                }
                if(optrs.Contains(exps[i])){
                    t1 = s.Top.Value;
                    s.Pop();
                    t2 = s.Top.Value;
                    s.Pop();
                    s.Push(new RPNTreeNode(exps[i], t2, t1));
                }
            }
            return s.Top.Value;
        }

        public static void WriteInFix(RPNTreeNode root)
        {
            if (root.Left != null)
            {
                Console.Write("(");
                WriteInFix(root.Left);
            }
            Console.Write(root.Value);
            if (root.Right != null)
            {
                WriteInFix(root.Right);
                Console.Write(")");
            }
        }

        public static void WritePostFix(RPNTreeNode root)
        {
            if(root.Left!=null)
                WritePostFix(root.Left);
            if(root.Right!=null)
                WritePostFix(root.Right);
            Console.Write(root.Value);
        }
     

    }
    public class RPNTreeNode
    {
        public char Value;
        public RPNTreeNode Left;
        public RPNTreeNode Right;

        public RPNTreeNode(char value , RPNTreeNode left , RPNTreeNode right)
        {
            Value = value;
            Left = left;
            Right = right;
        }
    }

}

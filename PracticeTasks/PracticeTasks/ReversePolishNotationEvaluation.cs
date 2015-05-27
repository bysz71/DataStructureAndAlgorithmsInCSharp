using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YuGeneric;

namespace PracticeTasks
{
    public class ReversePolishNotationEvaluation
    {
        public static void Go()
        {
            string expr = "27 3 4 6 * + / 8 +";
            int result = RPNEvaluator.Evaluate(expr);
            Console.WriteLine(result);
        }
    }

    public class RPNEvaluator
    {
        public static int Evaluate(string expr)
        {
            YuGeneric.Stack<int> stack = new YuGeneric.Stack<int>();

            var operatorSet = new HashSet<string>();
            operatorSet.Add("+");
            operatorSet.Add("-");
            operatorSet.Add("*");
            operatorSet.Add("/");

            string[] items = expr.Split(' ');

            int op1, op2, result;
            int n;
            for (int i = 0; i < items.Length; i++)
            {
                if (int.TryParse(items[i], out n))
                {
                    stack.Push(Int32.Parse(items[i]));
                }

                if (operatorSet.Contains(items[i]))
                {
                    if (stack.IsEmpty())
                    {
                        Console.WriteLine("Not enough oprand.");
                        System.Environment.Exit(1);
                    }
                    op2 = stack.Top.Value;
                    stack.Pop();
                    if (stack.IsEmpty())
                    {
                        Console.WriteLine("Not enough oprand.");
                        System.Environment.Exit(1);
                    }
                    op1 = stack.Top.Value;
                    stack.Pop();
                    result = calc(op1, op2, items[i]);
                    stack.Push(result);
                }
            }
            result = stack.Top.Value;
            stack.Pop();
            if (!stack.IsEmpty())
            {
                Console.WriteLine("Two many oprand.");
                System.Environment.Exit(1);
            }
            return result;
        }

        public static int calc(int op1, int op2, string oprt)
        {
            if (oprt == "+")
                return op1 + op2;
            if (oprt == "-")
                return op1 - op2;
            if (oprt == "*")
                return op1 * op2;
            if (oprt == "/")
            {
                try
                {
                    return op1 / op2;
                }
                catch(DivideByZeroException)
                {
                    Console.WriteLine("Division of {0} by zero.", op1);
                    System.Environment.Exit(1);
                }
            }
            throw new System.InvalidOperationException("Operator not iligible");
            //System.Environment.Exit(1);
        }
    }
}

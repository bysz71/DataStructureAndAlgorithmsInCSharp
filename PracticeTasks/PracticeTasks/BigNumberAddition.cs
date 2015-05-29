using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YuGeneric;

namespace PracticeTasks
{
    public class BigNumberAddition
    {
        public static void Run()
        {
            var op1 = new BigNumber("000000000000");
            var op2 = new BigNumber("000000000001");
            var sum = op1 + op2;

            op1 = new BigNumber("99");
            op2 = new BigNumber("1");
            sum = op1 + op2;

            op1 = new BigNumber("999999999999");
            op2 = new BigNumber("999999999999");
            sum = op1 + op2;
        }
    }

    public class BigNumber
    {
        private LList<char> _list;

        public BigNumber()
        {
            _list = new LList<char>();
        }

        public BigNumber(string bigNumString){
            _list = new LList<char>();
            StringToList(bigNumString);
        }

        public LListNode<char> First
        {
            get
            {
                return _list.First;
            }
        }

        private void AddLast(char sum)
        {
            _list.AddLast(sum);
        }

        /// <summary>
        /// Save a string into the list in a reverse way
        /// It is for iterating convinience
        /// </summary>
        /// <param name="bigNumString"></param>
        private void StringToList(string bigNumString){
            char[] chars = bigNumString.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                _list.AddFirst(chars[i]);
            }
        }

        /// <summary>
        /// check if the list is empty
        /// </summary>
        /// <returns></returns>
        private bool IsEmpty()
        {
            if (_list.IsEmpty())
                return true;
            else
                return false;
        }

        /// <summary>
        /// Reversely write the list to the screen
        /// </summary>
        public void Write()
        {
            var current = _list.First;
            string temp = "";
            while (current != null)
            {
                temp = current.Value + temp;
                current = current.Next;
            }
            Console.WriteLine(temp);
        }

        /// <summary>
        /// operator + overloaded
        /// addtion of 2 bignumber can use + now
        /// write the oprands and result to the screen
        /// return a sum bignumber
        /// </summary>
        /// <param name="op1">LHS oprand</param>
        /// <param name="op2">RHS oprand</param>
        /// <returns>sum bignumber</returns>
        public static BigNumber operator +(BigNumber op1, BigNumber op2)
        {
            if (op1.IsEmpty() && op2.IsEmpty())
            {
                return null;
            }
            else if (op1.IsEmpty())
            {
                return op2;
            }
            else if (op2.IsEmpty())
            {
                return op1;
            }
            else
            {
                int sum ;
                int carry = 0;
                var current1 = op1.First;
                var current2 = op2.First;
                var result = new BigNumber();

                //if any of those 2 still have digits, looping
                while (current1 != null || current2 != null)
                {
                    //reset sum to 0 every turn of loop
                    //take the carry value from last turn
                    sum = 0;

                    //if available add current value to the sum
                    //Char.GetNumericValue returns int of char's literal value
                    //thus it does not need to go through ASCII conversion
                    if (current1 != null)
                    {
                        sum += (int)Char.GetNumericValue(current1.Value);
                        current1 = current1.Next;
                    }

                    if (current2 != null)
                    {
                        sum += (int)Char.GetNumericValue(current2.Value);
                        current2 = current2.Next;
                    }

                    //add carry to sum, last turn carry now expired
                    sum += carry;

                    //new carry and new sum
                    carry = sum / 10;
                    sum = sum % 10;

                    //add sum to the list
                    //sum must add 48 according to ASCII table to make a char's literal is this sum
                    //AddLast because need to make sure lower digits are at LHS of the list
                    result.AddLast((char)(sum+48));
                }

                //if carry is not zero, and a new node in the list represent 1
                if (carry == 1)
                    result.AddLast((char)49);

                //print result to screen
                op1.Write();
                Console.WriteLine("+");
                op2.Write();
                Console.WriteLine("=");
                result.Write();

                return result;
            }
        }
    }
}

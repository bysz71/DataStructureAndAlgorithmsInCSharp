using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YuGeneric;
using PracticeTasks;

namespace PracticeTaskUnitTest
{
    [TestClass]
    public class UTBigNumber
    {
        [TestMethod]
        public void BigNumberConstructor(){
            var op1 = new BigNumber();
            var op2 = new BigNumber("21389101312");
        }

        [TestMethod]
        public void BigNumberFirst()
        {
            var op1 = new BigNumber("12345");
            Console.WriteLine(op1.First.Value);
        }

        [TestMethod]
        public void BigNumberWrite()
        {
            var op1 = new BigNumber("123123213");
            op1.Write();
        }

        [TestMethod]
        public void BigNumberPlusOverloading()
        {
            var op1 = new BigNumber("2139583949");
            var op2 = new BigNumber("0192309890213");
            var op3 = new BigNumber("0");
            var op4 = new BigNumber();

            var sum1 = op1 + op2;
            var sum2 = op2 + op3;
            var sum3 = op3 + op4;
        }
    }
}

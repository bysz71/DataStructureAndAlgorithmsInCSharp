using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yu.DataStructure.Generic;

namespace Yu
{
    [TestClass]
    public class UnitTestTestClass
    {
        [TestMethod]
        public void TestReturnObj()
        {
            var x = TestClass.ReturnObj();
            Console.Write(x.i + "--" + x.str);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YuGeneric;


namespace UnitTestYuGeneric
{
    [TestClass]
    public class UnitTestLList
    {
        [TestMethod]
        public void LListConstructor()
        {
            var lListString = new LList<string>();
            var lListInt = new LList<int>();
            var lListBool = new LList<bool>();
        }
    }
}

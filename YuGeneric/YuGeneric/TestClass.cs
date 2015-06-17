using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yu
{
    public class TestClass
    {
        public static TestObj ReturnObj()
        {
            var to = new TestObj();
            return to;
        }
    }

    public class TestObj
    {
        public int i;
        public string str;

        public TestObj()
        {
            i = 10;
            str = "aaa";
        }
    }
}

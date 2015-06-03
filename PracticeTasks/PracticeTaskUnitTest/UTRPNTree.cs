using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticeTasks;

namespace PracticeTaskUnitTest
{
    [TestClass]
    public class UTRPNTree
    {
        [TestMethod]
        public void RPNTreeRPNToTree()
        {
            var root = RPNTree.RPNToTree("34+78+*5+");
            Console.Write(root.Value);
        }

        [TestMethod]
        public void RPNTreeWriteInFix()
        {
            var root = RPNTree.RPNToTree("34+78+*5+");
            RPNTree.WriteInFix(root);
        }

        [TestMethod]
        public void RPNTreeWritePostFix()
        {
            var root = RPNTree.RPNToTree("34+78+*5+");
            RPNTree.WritePostFix(root);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yu.DataStructure.NonGeneric;

namespace Yu.DataStructure.NonGenericTest
{
    [TestClass]
    public class AdvancedSortTest
    {
        [TestMethod]
        public void MergeSortRecTest()
        {
            int[] data = new int[] { 3, 7, 2, 6, 2, 8, 9, 0, 15, 27, 11, 9 };
            int[] temp = new int[12];
            AdvancedSort.MergeSortRec(data, temp, 0, 11);
            foreach (int i in data)
            {
                Console.Write(i + " ");
            }
        }
    }
}

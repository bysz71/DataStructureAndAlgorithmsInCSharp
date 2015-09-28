using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingAlgorithms;

namespace UnitTestSortingAlgorithms
{
    [TestClass]
    public class UnitTestBinarySort
    {
        [TestMethod]
        public void TestMethodQuickSort()
        {
            var nums = new int[] { 3, 9, 2, 5, 6, 4, 11, 7, 12 };
            BinarySort.QuickSort(nums, 0, nums.Length - 1);
            CollectionAssert.AreEqual(new int[] { 2, 3, 4, 5, 6, 7, 9, 11, 12 }, nums);
        }
    }
}

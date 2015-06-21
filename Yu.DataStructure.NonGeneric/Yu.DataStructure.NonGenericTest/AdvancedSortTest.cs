using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yu.DataStructure.NonGeneric;

namespace Yu.DataStructure.NonGenericTest
{
    [TestClass]
    public class AdvancedSortTest
    {
        [TestMethod]
        public void TestMergeSort()
        {
            int[] data = new int[] { 10, 7, 2, 6, 2, 8, 9, 0, 15, 27, 11, 9 };
            int[] temp = new int[12];
            AdvancedSort.MergeSort(data, temp, 0, 11);
            foreach (int i in data)
            {
                Console.Write(i + " ");
            }
        }

        [TestMethod]
        public void TestSwap()
        {
            int[] data = new int[] { 10, 7, 2, 6, 2, 8, 9, 0, 15, 27, 11, 9 };
            AdvancedSort.Swap(data, 0, 11);
            AdvancedSort.PrintArray(data);
        }

        [TestMethod]
        public void TestQuickSort()
        {
            int[] data = new int[] { 7, 3, 8, 2, 5, 6, 0, 1, 9, 4 };
            AdvancedSort.QuickSort(data, 0, 9);
            foreach (int i in data)
            {
                Console.Write(i + " ");
            }
        }

        [TestMethod]
        public void TestRadixSort()
        {
            int[] data = new int[] { 5, 37, 1, 61, 11, 59, 48, 19 };
            AdvancedSort.RadixSort(data);
            foreach (int i in data)
            {
                Console.Write(i + " ");
            }
        }

        [TestMethod]
        public void TestHeapSort()
        {
            int[] data = new int[] { 5, 37, 1, 61, 11, 59, 48, 19 };
            AdvancedSort.HeapSort(data);
            foreach (int i in data)
            {
                Console.Write(i + " ");
            }
        }
    }
}

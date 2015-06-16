using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yu.DataStructure.NonGeneric;

namespace Yu.DataStructure.NonGenericTest
{
    [TestClass]
    public class SortTest
    {
        [TestMethod]
        public void TestSelectionSort()
        {
            int[] array = { 4, 7, 2, 3, 9, 8, 0, 1, 5, 6 };
            Sort.SelectionSort(array);
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
        }

        [TestMethod]
        public void TestInsertionSort()
        {
            int[] array = { 4, 7, 2, 3, 9, 8, 0, 1, 5, 6 };
            Sort.InsertionSort(array);
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
        }

        [TestMethod]
        public void TestBubbleSort()
        {
            int[] array = { 4, 7, 2, 3, 9, 8, 0, 1, 5, 6 };
            Sort.BubbleSort(array);
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
        }
    }
}

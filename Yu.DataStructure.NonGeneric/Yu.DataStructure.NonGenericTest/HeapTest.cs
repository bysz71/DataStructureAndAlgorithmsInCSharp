using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yu.DataStructure.NonGeneric;
using System.Collections.Generic;

namespace Yu.DataStructure.NonGenericTest
{
    [TestClass]
    public class UnitTestHeap
    {
        public void HeapInsertALot(Heap heap)
        {
            heap.Insert(10);
            heap.Insert(20);
            heap.Insert(5);
            heap.Insert(0);
            heap.Insert(28);
            heap.Insert(3);
            heap.Insert(15);
        }

        [TestMethod]
        public void HeapConstructor()
        {
            var heap = new Heap();
        }

        [TestMethod]
        public void HeapListInsert()
        {
            var heap = new Heap();
            heap.Insert(10);
            heap.Insert(20);
            heap.Insert(5);
            heap.Insert(5);
        }

        [TestMethod]
        public void HeapListPrint()
        {
            var heap = new Heap();
            HeapInsertALot(heap);
            heap.Print();
        }

        [TestMethod]
        public void HeapListDelete()
        {
            var heap = new Heap();
            HeapInsertALot(heap);
            heap.Print();
            heap.DeleteRoot();
            heap.Print();
            heap.DeleteRoot();
            heap.Print();
        }

        [TestMethod]
        public void HeapListMaxIndex()
        {
            var heap = new Heap();
            HeapInsertALot(heap);
            Console.WriteLine(heap.MaxIndex(1));
            Console.WriteLine(heap.MaxIndex(3));
            Console.WriteLine(heap.MaxIndex(5));
        }
    }
}

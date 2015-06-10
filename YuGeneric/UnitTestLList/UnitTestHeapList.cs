using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YuGeneric;
using System.Collections.Generic;

namespace UnitTestYuGeneric
{
    [TestClass]
    public class UnitTestHeapList
    {
        public void HeapListInsertALot(HeapList heap)
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
        public void HeapListConstructor()
        {
            var heap = new HeapList();
        }

        [TestMethod]
        public void HeapListInsert()
        {
            var heap = new HeapList();
            heap.Insert(10);
            heap.Insert(20);
            heap.Insert(5);
            heap.Insert(5);
        }

        [TestMethod]
        public void HeapListPrint()
        {
            var heap = new HeapList();
            HeapListInsertALot(heap);
            heap.Print();
        }

        [TestMethod]
        public void HeapListDelete()
        {
            var heap = new HeapList();
            HeapListInsertALot(heap);
            heap.Print();
            heap.DeleteRoot();
            heap.Print();
            heap.DeleteRoot();
            heap.Print();
        }

        [TestMethod]
        public void HeapListMaxIndex()
        {
            var heap = new HeapList();
            HeapListInsertALot(heap);
            Console.WriteLine(heap.MaxIndex(1));
            Console.WriteLine(heap.MaxIndex(3));
            Console.WriteLine(heap.MaxIndex(5));
        }
    }
}

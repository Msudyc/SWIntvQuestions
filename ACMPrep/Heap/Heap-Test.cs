using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    [TestClass]
    public partial class HeapIntv
    {
        [TestMethod]
        public void HeapIntv_HeapTest1()
        {
            Heap<int> heap = new Heap<int>();
            heap.Insert(5);
            heap.Insert(7);
            heap.Insert(3);
            heap.Insert(8);
            Assert.AreEqual(3, heap.Peek());
            Assert.AreEqual(3, heap.Delete());
            Assert.AreEqual(5, heap.Delete());
            Assert.AreEqual(7, heap.Peek());
        }
    };
}
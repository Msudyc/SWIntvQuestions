using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class HeapIntv
    {
        [TestMethod]
        public void HeapIntv_GetFirstNSmallSumsTest1()
        {
            int[] a = { 9, 5, 11 };
            int[] b = { 3, 20, 8 };
            List<int> A = new List<int>(a);
            List<int> B = new List<int>(b);
            List<int> res = GetFirstNSmallSums(A, B);
            Assert.AreEqual(8, res[0]);
            Assert.AreEqual(12, res[1]);
            Assert.AreEqual(13, res[2]);
        }

        [TestMethod]
        public void HeapIntv_GetFirstNSmallSumsTest2()
        {
            int[] a = { 3, 5, 4, 2, 1 };
            int[] b = { 2, 3, 5, 1, 4 };
            List<int> A = new List<int>(a);
            List<int> B = new List<int>(b);
            List<int> res = GetFirstNSmallSums(A, B);
            Assert.AreEqual(2, res[0]);
            Assert.AreEqual(3, res[1]);
            Assert.AreEqual(3, res[2]);
            Assert.AreEqual(4, res[3]);
            Assert.AreEqual(4, res[4]);
        }
    };
}
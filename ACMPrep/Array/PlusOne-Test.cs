using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class ArrayIntv
    {
        [TestMethod]
        public void ArrayIntv_PlusOneTest1()
        {
            int[] row0 = { 1, 0, 1, 0, 0, 1 };
            List<int> r = PlusOne(new List<int>(row0));
            Assert.AreEqual(6, r.Count);
            Assert.AreEqual(1, r[0]);
            Assert.AreEqual(0, r[1]);
            Assert.AreEqual(1, r[2]);
            Assert.AreEqual(0, r[3]);
            Assert.AreEqual(0, r[4]);
            Assert.AreEqual(2, r[5]);
        }

        [TestMethod]
        public void ArrayIntv_PlusOneTest2()
        {
            int[] row0 = { 9, 9, 9, 9, 9, 9 };
            List<int> r = PlusOne(new List<int>(row0));
            Assert.AreEqual(7, r.Count);
            Assert.AreEqual(1, r[0]);
            Assert.AreEqual(0, r[1]);
            Assert.AreEqual(0, r[2]);
            Assert.AreEqual(0, r[3]);
            Assert.AreEqual(0, r[4]);
            Assert.AreEqual(0, r[5]);
            Assert.AreEqual(0, r[6]);
        }

        [TestMethod]
        public void ArrayIntv_PlusOneTest3()
        {
            int[] row0 = { 1, 9, 9, 9, 9, 8 };
            List<int> r = PlusOne(new List<int>(row0));
            Assert.AreEqual(6, r.Count);
            Assert.AreEqual(1, r[0]);
            Assert.AreEqual(9, r[1]);
            Assert.AreEqual(9, r[2]);
            Assert.AreEqual(9, r[3]);
            Assert.AreEqual(9, r[4]);
            Assert.AreEqual(9, r[5]);
        }
    };
}
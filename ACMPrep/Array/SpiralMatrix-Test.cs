using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class ArrayIntv
    {
        [TestMethod]
        public void ArrayIntv_SpiralOrderTest1()
        {
            int[,] t = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            List<int> r = SpiralOrder(t);
            Assert.AreEqual(1, r[0]);
            Assert.AreEqual(2, r[1]);
            Assert.AreEqual(3, r[2]);
            Assert.AreEqual(6, r[3]);
            Assert.AreEqual(9, r[4]);
            Assert.AreEqual(8, r[5]);
            Assert.AreEqual(7, r[6]);
            Assert.AreEqual(4, r[7]);
            Assert.AreEqual(5, r[8]);
        }

        [TestMethod]
        public void ArrayIntv_SpiralOrderTest2()
        {
            int[,] t = { { 1, 2 }, { 3, 4 } };
            List<int> r = SpiralOrder(t);
            Assert.AreEqual(1, r[0]);
            Assert.AreEqual(2, r[1]);
            Assert.AreEqual(4, r[2]);
            Assert.AreEqual(3, r[3]);
        }
    };
}
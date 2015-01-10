using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class ArrayIntv
    {
        [TestMethod]
        public void ArrayIntv_RotateTest1()
        {
            int[,] t = { { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 } };
            Rotate(t);
            Assert.AreEqual(1, t[0, 0]);
            Assert.AreEqual(1, t[0, 1]);
            Assert.AreEqual(1, t[0, 2]);
            Assert.AreEqual(2, t[1, 0]);
            Assert.AreEqual(2, t[1, 1]);
            Assert.AreEqual(2, t[1, 2]);
            Assert.AreEqual(3, t[2, 0]);
            Assert.AreEqual(3, t[2, 1]);
            Assert.AreEqual(3, t[2, 2]);
        }

        [TestMethod]
        public void ArrayIntv_RotateTest2()
        {
            int[,] t = { { 1, 2 }, { 1, 2 } };
            Rotate(t);
            Assert.AreEqual(1, t[0, 0]);
            Assert.AreEqual(1, t[0, 1]);
            Assert.AreEqual(2, t[1, 0]);
            Assert.AreEqual(2, t[1, 0]);
        }
    };
}
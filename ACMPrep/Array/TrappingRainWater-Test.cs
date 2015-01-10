using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class ArrayIntv
    {
        [TestMethod]
        public void ArrayIntv_TrapTest1()
        {
            int[] A = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
            Assert.AreEqual(6, Trap(A));
        }

        [TestMethod]
        public void ArrayIntv_TrapTest2()
        {
            int[] A = { 0, 1 };
            Assert.AreEqual(0, Trap(A));
        }

        [TestMethod]
        public void ArrayIntv_TrapTest3()
        {
            int[] A = { 1 };
            Assert.AreEqual(0, Trap(A));
        }

        [TestMethod]
        public void ArrayIntv_TrapTest4()
        {
            int[] A = { 0, 1, 1, 2, 1 };
            Assert.AreEqual(0, Trap(A));
        }

        [TestMethod]
        public void ArrayIntv_TrapTest5()
        {
            int[] A = { 0, 1, 0, 0, 1, 0 };
            Assert.AreEqual(2, Trap(A));
        }
    };
}
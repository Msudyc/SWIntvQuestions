using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class ArrayIntv
    {
        [TestMethod]
        public void ArrayIntv_MaxSubArrayTest1()
        {
            int[] A = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            Assert.AreEqual(6, MaxSubArray(A, 9));
        }

        [TestMethod]
        public void ArrayIntv_MaxSubArrayTest2()
        {
            int[] A = { -2, 1, 1, 4, -1 };
            Assert.AreEqual(6, MaxSubArray(A, 5));
        }

        [TestMethod]
        public void ArrayIntv_MaxSubArrayTest3()
        {
            int[] A = { -2, 1, 1, 4, -1, 6 };
            Assert.AreEqual(11, MaxSubArray(A, 6));
        }

        [TestMethod]
        public void ArrayIntv_MaxSubArrayTest4()
        {
            int[] A = { 0, 1, 1, 4, 1, 6 };
            Assert.AreEqual(13, MaxSubArray(A, 6));
        }

        [TestMethod]
        public void ArrayIntv_MaxSubArrayTest5()
        {
            int[] A = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            Assert.AreEqual(6, MaxSubArrayDV(A, 9));
        }

        [TestMethod]
        public void ArrayIntv_MaxSubArrayTest6()
        {
            int[] A = { -2, 1, 1, 4, -1 };
            Assert.AreEqual(6, MaxSubArrayDV(A, 5));
        }

        [TestMethod]
        public void ArrayIntv_MaxSubArrayTest7()
        {
            int[] A = { -2, 1, 1, 4, -1, 6 };
            Assert.AreEqual(11, MaxSubArrayDV(A, 6));
        }

        [TestMethod]
        public void ArrayIntv_MaxSubArrayTest8()
        {
            int[] A = { 0, 1, 1, 4, 1, 6 };
            Assert.AreEqual(13, MaxSubArrayDV(A, 6));
        }
    };
}
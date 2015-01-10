using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class ArrayIntv
    {
        [TestMethod]
        public void ArrayIntv_FirstMissingPositiveTest1()
        {
            int[] A = {0, -1, -5, 4, 3, 7, 9, 1};
            Assert.AreEqual(2, FirstMissingPositive(A));
        }

        [TestMethod]
        public void ArrayIntv_FirstMissingPositiveTest2()
        {
            int[] A = {0, 2, -5, 4, 3, 7, 9, 1};
            Assert.AreEqual(5, FirstMissingPositive(A));
        }

        [TestMethod]
        public void ArrayIntv_FirstMissingPositiveTest3()
        {
            int[] A = {0};
            Assert.AreEqual(1, FirstMissingPositive(A));
        }

        [TestMethod]
        public void ArrayIntv_FirstMissingPositiveTest4()
        {
            int[] A = {0, 1, 2, 3, 4, 5};
            Assert.AreEqual(6, FirstMissingPositive(A));
        }
    };
}
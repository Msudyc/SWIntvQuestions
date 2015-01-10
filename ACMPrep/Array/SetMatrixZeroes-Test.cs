using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class ArrayIntv
    {
        [TestMethod]
        public void ArrayIntv_SetZeroesTest1()
        {
            int [,] t = {{1, 0, 6}, {2, 1, 3}, {4, 0, 5}};
            SetZeroes(t);
            Assert.AreEqual(0, t[0, 0]);
            Assert.AreEqual(0, t[2, 2]);
        }

        [TestMethod]
        public void ArrayIntv_SetZeroesTest2()
        {
            int [,] t = {{1, 0, 6, 1}, {2, 1, 3, 3}, {4, 0, 5, 5}};
            SetZeroes(t);
            Assert.AreEqual(0, t[0, 0]);
            Assert.AreEqual(0, t[2, 3]);
        }
    };
}
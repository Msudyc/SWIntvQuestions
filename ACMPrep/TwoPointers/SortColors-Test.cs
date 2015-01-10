using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class TwoPointers
    {
        [TestMethod]
        public void TwoPointers_SortColorsTest1()
        {
            int[] t = {1, 2, 1, 0, 1, 0};
            SortColors(t);
            Assert.AreEqual(0, t[0]);
            Assert.AreEqual(0, t[1]);
            Assert.AreEqual(1, t[2]);
            Assert.AreEqual(1, t[3]);
            Assert.AreEqual(1, t[4]);
            Assert.AreEqual(2, t[5]);
        }

        [TestMethod]
        public void TwoPointers_SortColorsTest2()
        {
            int[] t = {1};
            SortColors(t);
            Assert.AreEqual(1, t[0]);
        }

        [TestMethod]
        public void TwoPointers_SortColorsTest3()
        {
            int[] t = {1, 2};
            SortColors(t);
            Assert.AreEqual(1, t[0]);
            Assert.AreEqual(2, t[1]);
        }
    };
}
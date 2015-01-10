using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class ArrayIntv
    {
        [TestMethod]
        public void ArrayIntv_MaxProfitTestII1()
        {
            int[] r0 = {1, 4, 3, 2, 6, 7, 4, 8, 9, 2};
            Assert.AreEqual(13, MaxProfitII(r0));
        }

        [TestMethod]
        public void ArrayIntv_MaxProfitTestII2()
        {
            int[] r0 = { 1 };
            Assert.AreEqual(0, MaxProfitII(r0));
        }

        [TestMethod]
        public void ArrayIntv_MaxProfitTestII3()
        {
            int[] r0 = { 1, 4 };
            Assert.AreEqual(3, MaxProfitII(r0));
        }

        [TestMethod]
        public void ArrayIntv_MaxProfitTestII4()
        {
            int[] r0 = { 1, 4, 0, 2 };
            Assert.AreEqual(5, MaxProfitII(r0));
        }
    };
}
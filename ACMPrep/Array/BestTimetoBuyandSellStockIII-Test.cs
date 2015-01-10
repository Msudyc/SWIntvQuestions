using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class ArrayIntv
    {
        [TestMethod]
        public void ArrayIntv_MaxProfitTestIII1()
        {
            int[] r0 = { 1, 4, 3, 2, 6, 7, 4, 8, 9, 2 };
            Assert.AreEqual(11, MaxProfitIII(r0));
        }

        [TestMethod]
        public void ArrayIntv_MaxProfitTestIII2()
        {
            int[] r0 = { 1 };
            Assert.AreEqual(0, MaxProfitIII(r0));
        }

        [TestMethod]
        public void ArrayIntv_MaxProfitTestIII3()
        {
            int[] r0 = { 1, 4 };
            Assert.AreEqual(3, MaxProfitIII(r0));
        }

        [TestMethod]
        public void ArrayIntv_MaxProfitTestIII4()
        {
            int[] r0 = { 1, 4, 0, 2 };
            Assert.AreEqual(5, MaxProfitIII(r0));
        }
    };
}
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    [TestClass]
    public partial class ArrayIntv
    {
        [TestMethod]
        public void ArrayIntv_MaxProfitTest1()
        {
            int[] r0 = { 1, 4, 3, 2, 6, 7, 4, 8, 9, 2 };
            Assert.AreEqual(8, MaxProfit(r0));
        }

        [TestMethod]
        public void ArrayIntv_MaxProfitTest2()
        {
            int[] r0 = {1};
            Assert.AreEqual(0, MaxProfit(r0));
        }

        [TestMethod]
        public void ArrayIntv_MaxProfitTest3()
        {
            int[] r0 = {1, 4};
            Assert.AreEqual(3, MaxProfit(r0));
        }

        [TestMethod]
        public void ArrayIntv_MaxProfitTest4()
        {
            int[] r0 = {1, 4, 0, 2};
            Assert.AreEqual(3, MaxProfit(r0));
        }
    };
}
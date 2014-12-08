using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FB
{
    public partial class FBEx
    {
        [TestMethod]
        public void FB_MaxProfitTest1()
        {
            int[] r0 = { 1, 4, 3, 2, 6, 7, 4, 8, 9, 2 };
            Assert.AreEqual(8, MaxProfit(r0));
        }

        [TestMethod]
        public void FB_MaxProfitTest2()
        {
            int[] r0 = {1};
            Assert.AreEqual(0, MaxProfit(r0));
        }

        [TestMethod]
        public void FB_MaxProfitTest3()
        {
            int[] r0 = {1, 4};
            Assert.AreEqual(3, MaxProfit(r0));
        }

        [TestMethod]
        public void FB_MaxProfitTest4()
        {
            int[] r0 = {1, 4, 0, 2};
            Assert.AreEqual(3, MaxProfit(r0));
        }
    };
}
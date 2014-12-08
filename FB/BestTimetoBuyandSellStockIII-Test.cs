using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FB
{
    public partial class FBEx
    {
        [TestMethod]
        public void FB_MaxProfitTestIII1()
        {
            int[] r0 = { 1, 4, 3, 2, 6, 7, 4, 8, 9, 2 };
            Assert.AreEqual(11, MaxProfitIII(r0));
        }

        [TestMethod]
        public void FB_MaxProfitTestIII2()
        {
            int[] r0 = { 1 };
            Assert.AreEqual(0, MaxProfitIII(r0));
        }

        [TestMethod]
        public void FB_MaxProfitTestIII3()
        {
            int[] r0 = { 1, 4 };
            Assert.AreEqual(3, MaxProfitIII(r0));
        }

        [TestMethod]
        public void FB_MaxProfitTestIII4()
        {
            int[] r0 = { 1, 4, 0, 2 };
            Assert.AreEqual(5, MaxProfitIII(r0));
        }
    };
}
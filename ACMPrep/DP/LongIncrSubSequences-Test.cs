using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    [TestClass]
    public partial class DP
    {
        [TestMethod]
        public void DP_LongestIncrSubSeqsTest1()
        {
            int[] test = {5, 2, 8, 6, 3, 6, 9, 7};
            Assert.AreEqual(4, LongestIncrSubSeqs(test));
        }

        [TestMethod]
        public void DP_LongestIncrSubSeqsTest2()
        {
            int[] test = { 5 };
            Assert.AreEqual(1, LongestIncrSubSeqs(test));
        }

        [TestMethod]
        public void DP_LongestIncrSubSeqsTest3()
        {
            int[] test = { };
            Assert.AreEqual(0, LongestIncrSubSeqs(test));
        }
    }
}

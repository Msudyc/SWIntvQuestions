using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class DynamicProgramming
    {
        [TestMethod]
        public void DynamicProgramming_LongestIncrSubSeqsTest1()
        {
            int[] test = {5, 2, 8, 6, 3, 6, 9, 7};
            Assert.AreEqual(4, LongestIncrSubSeqs(test));
        }

        [TestMethod]
        public void DynamicProgramming_LongestIncrSubSeqsTest2()
        {
            int[] test = { 5 };
            Assert.AreEqual(1, LongestIncrSubSeqs(test));
        }

        [TestMethod]
        public void DynamicProgramming_LongestIncrSubSeqsTest3()
        {
            int[] test = { };
            Assert.AreEqual(0, LongestIncrSubSeqs(test));
        }
    }
}

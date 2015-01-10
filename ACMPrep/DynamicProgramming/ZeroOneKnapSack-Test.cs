using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class DynamicProgramming
    {
        [TestMethod]
        public void DynamicProgramming_ZeroOneKnapSackTest1()
        {
            int[] weights = {5, 4, 3, 2, 1};
            int[] values = { 1, 2, 3, 4, 5 };
            Assert.AreEqual(14, ZeroOneKnapSack(weights, values, 10));
        }

        [TestMethod]
        public void DynamicProgramming_ZeroOneKnapSackTest2()
        {
            int[] weights = { 5, 4, 3, 2, 1 };
            int[] values = { 1, 2, 3, 4, 5 };
            Assert.AreEqual(14, ZeroOneKnapSack2(weights, values, 10));
        }
    }
}

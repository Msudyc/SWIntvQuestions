using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class TwoPointers
    {
        [TestMethod]
        public void TwoPointers_TwoSumTest1()
        {
            int[] test = {1, 3, 4, 5, 7, 8};
            List<int> result = TwoSum(test, 10);
            Assert.AreEqual(2, result[0]);
            Assert.AreEqual(5, result[1]);
        }
    };
}
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class BinarySearch
    {
        [TestMethod]
        public void BinarySearch_FindMinDupTest1()
        {
            int[] num = { 4, 5, 5, 6, 7, 8, 0, 1, 1, 2 };
            Assert.AreEqual(0, FindMinDup(num));
        }
    };
}
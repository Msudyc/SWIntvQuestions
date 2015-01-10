using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class Sort
    {
        [TestMethod]
        public void Sort_MaximumGapTest1()
        {
            int[] test = { 2, 3, 1, 5, 7, 6, 11, 4, 6, 13, 15 };
            Assert.AreEqual(4, MaximumGap(test));
        }
    };
}
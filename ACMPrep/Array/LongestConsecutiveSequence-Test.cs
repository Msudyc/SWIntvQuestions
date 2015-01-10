using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class ArrayIntv
    {
        [TestMethod]
        public void ArrayIntv_LongestConsecutiveTest1()
        {
            int[] r0 = { 100, 4, 300, 2, 6, 1, 56, 3, 9, 30 };
            Assert.AreEqual(4, LongestConsecutive(r0));
        }

        [TestMethod]
        public void ArrayIntv_LongestConsecutiveTest2()
        {
            int[] r0 = { 100 };
            Assert.AreEqual(1, LongestConsecutive(r0));
        }
    };
}
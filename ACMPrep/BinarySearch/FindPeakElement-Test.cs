using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class BinarySearch
    {
        [TestMethod]
        public void BinarySearch_FindPeakElementTest1()
        {
            int[] test = { 1, 2, 3, 1 };
            Assert.AreEqual(2, FindPeakElement(test));
        }

        [TestMethod]
        public void BinarySearch_FindPeakElementTest2()
        {
            int[] test = { 1, 2, 3, 4 };
            Assert.AreEqual(3, FindPeakElement(test));
        }

        [TestMethod]
        public void BinarySearch_FindPeakElementTest3()
        {
            int[] test = { 5, 3, 3, 1 };
            Assert.AreEqual(0, FindPeakElement(test));
        }
    };
}
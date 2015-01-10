using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class BinarySearch
    {
        [TestMethod]
        public void BinarySearch_SearchTest1()
        {
            int[] t = { 7, 7, 8, 9, 9, 1, 1, 2, 3, 3, 4, 4, 5 };
            Assert.IsTrue(Search(t, 13, 4));
        }

        [TestMethod]
        public void BinarySearch_SearchTest2()
        {
            int[] t = { 7, 7, 8, 9, 9, 1, 1, 2, 3, 3, 4, 4, 5 };
            Assert.IsFalse(Search(t, 13, 6));
        }

        [TestMethod]
        public void BinarySearch_SearchTest3()
        {
            int[] t = {7};
            Assert.IsTrue(Search(t, 1, 7));
        }

        [TestMethod]
        public void BinarySearch_SearchTest4()
        {
            int[] t = {7};
            Assert.IsFalse(Search(t, 1, 4));
        }
    };
}
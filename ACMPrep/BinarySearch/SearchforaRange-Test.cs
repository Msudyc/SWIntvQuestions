using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class BinarySearch
    {
        [TestMethod]
        public void BinarySearch_SearchRangeTest1()
        {
            int[] t = { 5, 7, 7, 8, 8, 10 };
            List<int> r = SearchRange(t, 8);
            Assert.AreEqual(3, r[0]);
            Assert.AreEqual(4, r[1]);
        }

        [TestMethod]
        public void BinarySearch_SearchRangeTest2()
        {
            int[] t = { 5, 5 };
            List<int> r = SearchRange(t, 5);
            Assert.AreEqual(0, r[0]);
            Assert.AreEqual(1, r[1]);
        }

        [TestMethod]
        public void BinarySearch_SearchRangeTest3()
        {
            int[] t = { 1, 5 };
            List<int> r = SearchRange(t, 5);
            Assert.AreEqual(1, r[0]);
            Assert.AreEqual(1, r[1]);
        }

        [TestMethod]
        public void BinarySearch_SearchRangeTest4()
        {
            int[] t = { 1, 5 };
            List<int> r = SearchRange(t, 8);
            Assert.AreEqual(-1, r[0]);
            Assert.AreEqual(-1, r[1]);
        }

        [TestMethod]
        public void BinarySearch_SearchRangeTest5()
        {
            int[] t = { 0 };
            List<int> r = SearchRange(t, 8);
            Assert.AreEqual(-1, r[0]);
            Assert.AreEqual(-1, r[1]);
        }

        [TestMethod]
        public void BinarySearch_SearchRangeTest6()
        {
            int[] t = { 8 };
            List<int> r = SearchRange(t, 9);
            Assert.AreEqual(-1, r[0]);
            Assert.AreEqual(-1, r[1]);
        }
    };
}
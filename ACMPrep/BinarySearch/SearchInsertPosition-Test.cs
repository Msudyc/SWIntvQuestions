using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class BinarySearch
    {
        [TestMethod]
        public void BinarySearch_SearchInsertTest1()
        {
            int[] t = {1, 3, 5, 6};
            Assert.AreEqual(1, SearchInsert(t, 2));
        }

        [TestMethod]
        public void BinarySearch_SearchInsertTest2()
        {
            int[] t = {1, 3, 5, 6};
            Assert.AreEqual(2, SearchInsert(t, 5));
        }

        [TestMethod]
        public void BinarySearch_SearchInsertTest3()
        {
            int[] t = {1, 3, 5, 6};
            Assert.AreEqual(4, SearchInsert(t, 8));
        }

        [TestMethod]
        public void BinarySearch_SearchInsertTest4()
        {
            int[] t = {2, 3, 5, 6};
            Assert.AreEqual(0, SearchInsert(t, 1));
        }
    };
}
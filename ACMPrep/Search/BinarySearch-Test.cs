using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    [TestClass]
    public partial class Search
    {
        [TestMethod]
        public void Search_BinarySearchTest1()
        {
            int[] test = { 1, 3, 4, 6, 7, };
            Assert.AreEqual(3, BinarySearch(test, 6));
        }

        [TestMethod]
        public void Search_BinarySearchTest2()
        {
            int[] test = { 1, 3, 4, 6, 7, };
            Assert.AreEqual(-1, BinarySearch(test, 5));
        }
    }
}

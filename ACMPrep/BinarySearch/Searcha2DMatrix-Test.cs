using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class BinarySearch
    {
        [TestMethod]
        public void BinarySearch_SearchMatrixTest1()
        {
            int[,] t = { { 1, 2, 3 }, { 5, 7, 9 }, { 10, 13, 15 } };
            Assert.IsTrue(SearchMatrix(t, 9));
        }

        [TestMethod]
        public void BinarySearch_SearchMatrixTest2()
        {
            int[,] t = {{1, 2, 3}, {5, 7, 9}, {10, 13, 15}};
            Assert.IsFalse(SearchMatrix(t, 11));
        }
    };
}
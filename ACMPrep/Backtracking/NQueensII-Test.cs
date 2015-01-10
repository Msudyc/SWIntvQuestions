using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class Backtracking
    {
        [TestMethod]
        public void Backtracking_TotalNQueensTest1()
        {
            Assert.AreEqual(2, TotalNQueens(4));
        }

        [TestMethod]
        public void Backtracking_TotalNQueensTest2()
        {
            Assert.AreEqual(0, TotalNQueens(3));
        }

        [TestMethod]
        public void Backtracking_TotalNQueensTest3()
        {
            Assert.AreEqual(10, TotalNQueens(5));
        }
    };
}
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class Backtracking
    {
        [TestMethod]
        public void Backtracking_SolveNQueensTest1()
        {
            List<List<string>> res = SolveNQueens(4);
            Assert.AreEqual(2, res.Count);
        }

        [TestMethod]
        public void Backtracking_SolveNQueensTest2()
        {
            List<List<string>> res = SolveNQueens(2);
            Assert.AreEqual(0, res.Count);
        }

        [TestMethod]
        public void Backtracking_SolveNQueensTest3()
        {
            List<List<string>> res = SolveNQueens(3);
            Assert.AreEqual(0, res.Count);
        }

        [TestMethod]
        public void Backtracking_SolveNQueensTest4()
        {
            List<List<string>> res = SolveNQueens(5);
            Assert.AreEqual(10, res.Count);
        }
    };
}
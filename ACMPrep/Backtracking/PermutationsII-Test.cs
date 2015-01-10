using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class Backtracking
    {
        [TestMethod]
        public void Backtracking_PermuteUniqueTest1()
        {
            List<int> t = new List<int>();
            t.Add(1); t.Add(2);
            List<List<int>> res = PermuteUnique(t);
            Assert.AreEqual(2, res.Count);
        }

        [TestMethod]
        public void Backtracking_PermuteUniqueTest2()
        {
            List<int> t = new List<int>();
            t.Add(1); t.Add(2); t.Add(3);
            List<List<int>> res = PermuteUnique(t);
            Assert.AreEqual(6, res.Count);
        }

        [TestMethod]
        public void Backtracking_PermuteUniqueTest3()
        {
            List<int> t = new List<int>();
            t.Add(1); t.Add(2); t.Add(2);
            List<List<int>> res = PermuteUnique(t);
            Assert.AreEqual(3, res.Count);
        }

        [TestMethod]
        public void Backtracking_PermuteUniqueTest4()
        {
            List<int> t = new List<int>();
            t.Add(1); t.Add(1);
            List<List<int>> res = PermuteUnique(t);
            Assert.AreEqual(1, res.Count);
        }
    };
}
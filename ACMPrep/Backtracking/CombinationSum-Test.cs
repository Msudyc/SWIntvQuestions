using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class Backtracking
    {
        [TestMethod]
        public void Backtracking_CombinationSumTest1()
        {
            List<int> t = new List<int>();
            t.Add(2); t.Add(3); t.Add(6); t.Add(7);
            List<List<int>> res = CombinationSum(t, 7);
            Assert.AreEqual(2, res.Count);
        }

        [TestMethod]
        public void Backtracking_CombinationSumTest2()
        {
            List<int> t = new List<int>();
            t.Add(2); t.Add(3); t.Add(6); t.Add(7);
            List<List<int>> res = CombinationSum(t, 6);
            Assert.AreEqual(3, res.Count);
        }

        [TestMethod]
        public void Backtracking_CombinationSumTest3()
        {
            List<int> t = new List<int>();
            t.Add(2); t.Add(3); t.Add(6); t.Add(7);
            List<List<int>> res = CombinationSum(t, 1);
            Assert.AreEqual(0, res.Count);
        }
    };
}
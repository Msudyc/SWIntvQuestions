using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class Backtracking
    {
        [TestMethod]
        public void Backtracking_CombinationSumIITest1()
        {
            List<int> t = new List<int>();
            t.Add(2); t.Add(3); t.Add(6); t.Add(7);
            List<List<int>> res = CombinationSum2(t, 7);
            Assert.AreEqual(1, res.Count);
        }

        [TestMethod]
        public void Backtracking_CombinationSumIITest2()
        {
            List<int> t = new List<int>();
            t.Add(2); t.Add(3); t.Add(6); t.Add(7);
            List<List<int>> res = CombinationSum2(t, 5);
            Assert.AreEqual(1, res.Count);
        }

        [TestMethod]
        public void Backtracking_CombinationSumIITest3()
        {
            List<int> t = new List<int>();
            t.Add(2); t.Add(3); t.Add(6); t.Add(7);
            t.Add(1); t.Add(1);
            List<List<int>> res = CombinationSum2(t, 6);
            Assert.AreEqual(2, res.Count);
        }
    };
}
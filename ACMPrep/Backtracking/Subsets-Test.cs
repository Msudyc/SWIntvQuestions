using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class Backtracking
    {
        [TestMethod]
        public void Backtracking_SubsetsTest1()
        {
            List<int> t = new List<int>();
            t.Add(1);
            t.Add(2);
            t.Add(3);
            List<List<int>> ret = Subsets(t);
            Assert.AreEqual(8, ret.Count);
        }

        [TestMethod]
        public void Backtracking_SubsetsTest2()
        {
            List<int> t = new List<int>();
            List<List<int>> ret = Subsets(t);
            Assert.AreEqual(1, ret.Count);
        }

        [TestMethod]
        public void Backtracking_SubsetsTest3()
        {
            List<int> t = new List<int>();
            t.Add(1);
            List<List<int>> ret = Subsets(t);
            Assert.AreEqual(2, ret.Count);
        }

        [TestMethod]
        public void Backtracking_SubsetsTest4()
        {
            List<int> t = new List<int>();
            t.Add(1);
            t.Add(2);
            t.Add(3);
            t.Add(4);
            List<List<int>> ret = Subsets(t);
            Assert.AreEqual(16, ret.Count);
        }
    };
}
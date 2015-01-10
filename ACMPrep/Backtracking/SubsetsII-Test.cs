using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class Backtracking
    {
        [TestMethod]
        public void Backtracking_SubsetsWithDupTest1()
        {
            int[] row0 = {2, 2, 2, 2};
            List<int> r0 = new List<int>(row0);
            List<List<int>> r = SubsetsWithDup(r0);
            Assert.AreEqual(5, r.Count);
        }

        [TestMethod]
        public void Backtracking_SubsetsWithDupTest2()
        {
            int[] row0 = {1};
            List<int> r0 = new List<int>(row0);
            List<List<int>> r = SubsetsWithDup(r0);
            Assert.AreEqual(2, r.Count);
        }

        [TestMethod]
        public void Backtracking_SubsetsWithDupTest3()
        {
            int[] row0 = {1, 2, 2, 4, 5};
            List<int> r0 = new List<int>(row0);
            List<List<int>> r = SubsetsWithDup(r0);
            Assert.AreEqual(24, r.Count);
        }

        [TestMethod]
        public void Backtracking_SubsetsWithDupTest4()
        {
            int[] row0 = {1, 2, 3};
            List<int> r0 = new List<int>(row0);
            List<List<int>> r = SubsetsWithDup(r0);
            Assert.AreEqual(8, r.Count);
        }
    };
}
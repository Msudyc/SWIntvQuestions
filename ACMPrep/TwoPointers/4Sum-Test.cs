using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class TwoPointers
    {
        [TestMethod]
        public void TwoPointers_FourSumTest1()
        {
            List<int> v = new List<int>();
            v.Add(-2);
            v.Add(0);
            v.Add(1);
            v.Add(1);
            v.Add(2);
            List<List<int>> r = FourSum(v, 0);
            Assert.AreEqual(1, r.Count);
        }

        [TestMethod]
        public void TwoPointers_FourSumTest2()
        {
            List<int> v = new List<int>();
            v.Add(-2);
            v.Add(0);
            v.Add(1);
            v.Add(2);
            List<List<int>> r = FourSum(v, 0);
            Assert.AreEqual(0, r.Count);
        }

        [TestMethod]
        public void TwoPointers_FourSumTest3()
        {
            List<int> v = new List<int>();
            v.Add(1);
            v.Add(0);
            v.Add(-1);
            v.Add(0);
            v.Add(-2);
            v.Add(2);
            List<List<int>> r = FourSum(v, 0);
            Assert.AreEqual(3, r.Count);
        }
    };
}
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class TwoPointers
    {
        [TestMethod]
        public void TwoPointers_ThreeSumTest1()
        {
            List<int> v = new List<int>();
            v.Add(-2);
            v.Add(0);
            v.Add(1);
            v.Add(1);
            v.Add(2);
            List<List<int>> r = ThreeSum(v);
            Assert.AreEqual(2, r.Count);
        }

        [TestMethod]
        public void TwoPointers_ThreeSumTest2()
        {
            List<int> v = new List<int>();
            v.Add(-1);
            v.Add(0);
            v.Add(1);
            v.Add(2);
            v.Add(-1);
            v.Add(-4);
            List<List<int>> r = ThreeSum(v);
            Assert.AreEqual(2, r.Count);
        }

        [TestMethod]
        public void TwoPointers_ThreeSumTest3()
        {
            List<int> v = new List<int>();
            v.Add(-1);
            v.Add(0);
            v.Add(1);
            v.Add(2);
            v.Add(-1);
            v.Add(-4);
            v.Add(0);
            v.Add(0);
            v.Add(0);
            v.Add(1);
            v.Add(0);
            v.Add(0);
            v.Add(0);
            List<List<int>> r = ThreeSum(v);
            Assert.AreEqual(3, r.Count);
        }
    };
}
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    [TestClass]
    public partial class TwoPointers
    {
        [TestMethod]
        public void TwoPointers_ThreeSumClosestTest1()
        {
            List<int> v = new List<int>();
            v.Add(-1);
            v.Add(2);
            v.Add(1);
            v.Add(-4);
            Assert.AreEqual(2, ThreeSumClosest(v, 1));
            v.Clear();
            v.Add(0);
            v.Add(2);
            v.Add(1);
            v.Add(-3);
            Assert.AreEqual(0, ThreeSumClosest(v, 1));
        }

        [TestMethod]
        public void TwoPointers_ThreeSumClosestTest2()
        {
            List<int> v = new List<int>();
            v.Add(-1);
            v.Add(2);
            v.Add(1);
            Assert.AreEqual(2, ThreeSumClosest(v, 5));
        }

        [TestMethod]
        public void TwoPointers_ThreeSumClosestTest3()
        {
            List<int> v = new List<int>();
            v.Add(-1);
            v.Add(2);
            Assert.AreEqual(0, ThreeSumClosest(v, 5));
        }
    };
}
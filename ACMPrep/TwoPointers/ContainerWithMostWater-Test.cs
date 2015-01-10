using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class TwoPointers
    {
        [TestMethod]
        public void TwoPointers_MaxAreaTest1()
        {
            List<int> t = new List<int>();
            t.Add(2);
            Assert.AreEqual(0, MaxAreaBF(t));
            t.Add(4);
            Assert.AreEqual(2, MaxAreaBF(t));
            t.Add(8);
            Assert.AreEqual(4, MaxAreaBF(t));
        }

        [TestMethod]
        public void TwoPointers_MaxAreaTest2()
        {
            List<int> t = new List<int>();
            t.Add(2);
            Assert.AreEqual(0, MaxArea(t));
            t.Add(4);
            Assert.AreEqual(2, MaxArea(t));
            t.Add(8);
            Assert.AreEqual(4, MaxArea(t));
        }
    };
}
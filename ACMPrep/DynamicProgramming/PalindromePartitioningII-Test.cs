using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class DynamicProgramming
    {
        [TestMethod]
        public void DynamicProgramming_MinCutTest1()
        {
            Assert.AreEqual(1, MinCut("aab"));
        }

        [TestMethod]
        public void DynamicProgramming_MinCutTest2()
        {
            Assert.AreEqual(0, MinCut("aa"));
        }

        [TestMethod]
        public void DynamicProgramming_MinCutTest3()
        {
            Assert.AreEqual(0, MinCut("b"));
        }
    };
}
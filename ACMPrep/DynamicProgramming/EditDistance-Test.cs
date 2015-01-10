using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class DynamicProgramming
    {
        [TestMethod]
        public void DynamicProgramming_MinDistanceTest1()
        {
            Assert.AreEqual(3, MinDistance("ok", "good"));
        }

        [TestMethod]
        public void DynamicProgramming_MinDistanceTest2()
        {
            Assert.AreEqual(2, MinDistance("gok", "good"));
        }

        [TestMethod]
        public void DynamicProgramming_MinDistanceTest3()
        {
            Assert.AreEqual(3, MinDistance("gok", ""));
        }

        [TestMethod]
        public void DynamicProgramming_MinDistanceTest4()
        {
            Assert.AreEqual(0, MinDistance("good", "good"));
        }
    };
}
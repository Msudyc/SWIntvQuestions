using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class DynamicProgramming
    {
        [TestMethod]
        public void DynamicProgramming_NumDistinctTest1()
        {
            Assert.AreEqual(3, NumDistinct("rabbbit", "rabbit"));
        }

        [TestMethod]
        public void DynamicProgramming_NumDistinctTest2()
        {
            Assert.AreEqual(2, NumDistinct("aab", "a"));
        }

        [TestMethod]
        public void DynamicProgramming_NumDistinctTest3()
        {
            Assert.AreEqual(1, NumDistinct("rabbitk", "rabbit"));
        }
    };
}
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class DynamicProgramming
    {
        [TestMethod]
        public void DynamicProgramming_NumTreesTest1()
        {
            Assert.AreEqual(5, NumTrees(3));
        }

        [TestMethod]
        public void DynamicProgramming_NumTreesTest2()
        {
            Assert.AreEqual(1, NumTrees(1));
        }

        [TestMethod]
        public void DynamicProgramming_NumTreesTest3()
        {
            Assert.AreEqual(2, NumTrees(2));
        }

        [TestMethod]
        public void DynamicProgramming_NumTreesTest4()
        {
            Assert.AreEqual(132, NumTrees(6));
        }
    };
}
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class DynamicProgramming
    {
        [TestMethod]
        public void DynamicProgramming_UniquePathsTest1()
        {
            Assert.AreEqual(2, UniquePaths(2, 2));
            Assert.AreEqual(28, UniquePaths(3, 7));
        }

        [TestMethod]
        public void DynamicProgramming_UniquePathsTest2()
        {
            Assert.AreEqual(3, UniquePaths(3, 2));
        }

        [TestMethod]
        public void DynamicProgramming_UniquePathsTest3()
        {
            Assert.AreEqual(1, UniquePaths(1, 2));
        }

        [TestMethod]
        public void DynamicProgramming_UniquePathsTest4()
        {
            Assert.AreEqual(1, UniquePaths(1, 1));
        }
    };
}
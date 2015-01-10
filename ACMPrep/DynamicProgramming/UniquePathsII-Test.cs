using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class DynamicProgramming
    {
        [TestMethod]
        public void DynamicProgramming_UniquePathsWithObstaclesTest1()
        {
            int[,] t = {{0, 0, 0}, {0, 1, 0}, {0, 0, 0}};
            Assert.AreEqual(2, UniquePathsWithObstacles(t));
        }

        [TestMethod]
        public void DynamicProgramming_UniquePathsWithObstaclesTest2()
        {
            int[,] t = { { 0, 0, 0 }, { 0, 1, 1 }, { 0, 0, 0 } };
            Assert.AreEqual(1, UniquePathsWithObstacles(t));
        }

        [TestMethod]
        public void DynamicProgramming_UniquePathsWithObstaclesTest3()
        {
            int[,] t = { { 0, 0, 0 } };
            Assert.AreEqual(1, UniquePathsWithObstacles(t));
        }

        [TestMethod]
        public void DynamicProgramming_UniquePathsWithObstaclesTest4()
        {
            int[,] t = { { 0, 1, 0 } };
            Assert.AreEqual(0, UniquePathsWithObstacles(t));
        }

        [TestMethod]
        public void DynamicProgramming_UniquePathsWithObstaclesTest5()
        {
            int[,] t = { { 0, 0, 0 }, { 0, 1, 1 }, { 0, 1, 0 } };
            Assert.AreEqual(0, UniquePathsWithObstacles(t));
        }
    };
}
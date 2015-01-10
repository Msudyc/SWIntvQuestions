using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class DynamicProgramming
    {
        [TestMethod]
        public void DynamicProgramming_MinPathSumTest1()
        {
            int [,] t = {{0, 2, 0}, {0, 1, 3}, {1, 1, 0}};
            Assert.AreEqual(2, MinPathSum(t));
        }

        [TestMethod]
        public void DynamicProgramming_MinPathSumTest2()
        {
            int [,] t = {{0, 2, 0, 1}, {0, 1, 3, 2}, {1, 1, 0, 3}};
            Assert.AreEqual(5, MinPathSum(t));
        }

        [TestMethod]
        public void DynamicProgramming_MinPathSumTest3()
        {
            int[,] t = {{0, 2, 0, 1}};
            Assert.AreEqual(3, MinPathSum(t));
        }

        [TestMethod]
        public void DynamicProgramming_MinPathSumTest4()
        {
            int[,] t = { { 0, 2, 0 }, { 0, 1, 3 }, { 1, 1, 0 } };
            Assert.AreEqual(2, MinPathSumDP(t));
        }

        [TestMethod]
        public void DynamicProgramming_MinPathSumTest5()
        {
            int[,] t = { { 0, 2, 0, 1 }, { 0, 1, 3, 2 }, { 1, 1, 0, 3 } };
            Assert.AreEqual(5, MinPathSumDP(t));
        }

        [TestMethod]
        public void DynamicProgramming_MinPathSumTest6()
        {
            //int[,] t = { { 0, 2, 0, 1 } };
            //Assert.AreEqual(3, Ex063.MinPathSumDP(t));
        }
    };
}
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class StackIntv
    {
        [TestMethod]
        public void StackIntv_LargestRectangleAreaTest1()
        {
            int[] row0 = {2, 3, 5, 8, 4, 3};
            List<int> t = new List<int>(row0);
            Assert.AreEqual(15, LargestRectangleArea(t));
        }

        [TestMethod]
        public void StackIntv_LargestRectangleAreaTest2()
        {
            int[] row0 = {2, 3};
            List<int> t = new List<int>(row0);
            Assert.AreEqual(4, LargestRectangleArea(t));
        }

        [TestMethod]
        public void StackIntv_LargestRectangleAreaTest3()
        {
            int[] row0 = {2};
            List<int> t = new List<int>(row0);
            Assert.AreEqual(2, LargestRectangleArea(t));
        }

        [TestMethod]
        public void StackIntv_LargestRectangleAreaTest4()
        {
            int[] row0 = {2, 3, 5};
            List<int> t = new List<int>(row0);
            Assert.AreEqual(6, LargestRectangleArea(t));
        }

        [TestMethod]
        public void StackIntv_LargestRectangleAreaTest5()
        {
            int[] row0 = {1, 1};
            List<int> t = new List<int>(row0);
            Assert.AreEqual(2, LargestRectangleArea(t));
        }
    };
}
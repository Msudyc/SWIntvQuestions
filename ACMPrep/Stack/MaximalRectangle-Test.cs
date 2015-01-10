using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class StackIntv
    {
        [TestMethod]
        public void StackIntv_MaximalRectangleTest1()
        {
            char[,] t = { { '0', '0', '0', '0' }, 
                          { '0', '0', '1', '1' }, 
                          { '0', '0', '1', '1' } };
            Assert.AreEqual(4, MaximalRectangle(t));
        }

        [TestMethod]
        public void StackIntv_MaximalRectangleTest2()
        {
            char[,] t = { { '0', '0', '0', '0' }, 
                          { '0', '0', '0', '1' }, 
                          { '0', '0', '0', '1' } };
            Assert.AreEqual(2, MaximalRectangle(t));
        }

        [TestMethod]
        public void StackIntv_MaximalRectangleTest3()
        {
            char[,] t = { { '0', '0', '0', '0' }, 
                          { '0', '0', '0', '0' }, 
                          { '0', '0', '0', '1' } };
            Assert.AreEqual(1, MaximalRectangle(t));
        }

        [TestMethod]
        public void StackIntv_MaximalRectangleTest4()
        {
            char[,] t = { { '0', '0', '0' } };
            Assert.AreEqual(0, MaximalRectangle(t));
        }

        [TestMethod]
        public void StackIntv_MaximalRectangleTest5()
        {
            char[,] t = new char[1, 1];
            Assert.AreEqual(0, MaximalRectangle(t));
        }
    };
}
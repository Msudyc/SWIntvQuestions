using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class ArrayIntv
    {
        [TestMethod]
        public void ArrayIntv_GenerateMatrixTest1()
        {
            int[,] r = GenerateMatrix(2);
            Assert.AreEqual(1, r[0,0]);
            Assert.AreEqual(2, r[0,1]);
            Assert.AreEqual(3, r[1,1]);
            Assert.AreEqual(4, r[1,0]);
        }

        [TestMethod]
        public void ArrayIntv_GenerateMatrixTest2()
        {
            int[,] r = GenerateMatrix(1);
            Assert.AreEqual(1, r[0,0]);
        }

        [TestMethod]
        public void ArrayIntv_GenerateMatrixTest3()
        {
            int[,] r = GenerateMatrix(3);
            Assert.AreEqual(1, r[0,0]);
            Assert.AreEqual(2, r[0,1]);
            Assert.AreEqual(3, r[0,2]);
            Assert.AreEqual(4, r[1,2]);
            Assert.AreEqual(5, r[2,2]);
            Assert.AreEqual(6, r[2,1]);
            Assert.AreEqual(7, r[2,0]);
            Assert.AreEqual(8, r[1,0]);
            Assert.AreEqual(9, r[1,1]);
        }
    };
}
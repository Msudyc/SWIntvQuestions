using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class ArrayIntv
    {
        [TestMethod]
        public void ArrayIntv_GenerateTest1()
        {
            List<List<int>> r = Generate(4);
            Assert.AreEqual(1, r[0][0]);
            Assert.AreEqual(1, r[1][0]);
            Assert.AreEqual(1, r[1][1]);
            Assert.AreEqual(1, r[2][0]);
            Assert.AreEqual(2, r[2][1]);
            Assert.AreEqual(1, r[2][2]);
            Assert.AreEqual(1, r[3][0]);
            Assert.AreEqual(3, r[3][1]);
            Assert.AreEqual(3, r[3][2]);
            Assert.AreEqual(1, r[3][3]);
        }
    };
}
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class ArrayIntv
    {
        [TestMethod]
        public void ArrayIntv_GetRowTest1()
        {
            List<int> r = GetRow(3);
            Assert.AreEqual(1, r[0]);
            Assert.AreEqual(3, r[1]);
            Assert.AreEqual(3, r[2]);
            Assert.AreEqual(1, r[3]);
        }
    };
}
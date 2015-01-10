using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class ArrayIntv
    {
        [TestMethod]
        public void ArrayIntv_MaxProductTest1()
        {
            int[] A = { 2, 3, -2, 4 };
            Assert.AreEqual(6, MaxProduct(A));
        }
    };
}
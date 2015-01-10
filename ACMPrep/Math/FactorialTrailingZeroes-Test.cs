using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class MathIntv
    {
        [TestMethod]
        public void MathIntv_TrailingZeroesTest1()
        {
            Assert.AreEqual(6, TrailingZeroes(26));
        }
    };
}
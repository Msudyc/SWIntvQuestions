using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class MathIntv
    {
        [TestMethod]
        public void MathIntv_PowTest1()
        {
            Assert.AreEqual(8.0, Pow(2.0, 3));
        }

        [TestMethod]
        public void MathIntv_PowTest2()
        {
            Assert.AreEqual(1.0, Pow(1.0, 3));
        }

        [TestMethod]
        public void MathIntv_PowTest3()
        {
            Assert.AreEqual(16.0, Pow(2.0, 4));
        }
    };
}
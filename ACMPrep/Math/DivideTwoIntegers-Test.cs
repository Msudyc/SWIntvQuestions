using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    [TestClass]
    public partial class MathIntv
    {
        [TestMethod]
        public void MathIntv_DivideTest1()
        {
            Assert.AreEqual(3, Divide(7, 2));
            Assert.AreEqual(4, Divide(12, 3));
            Assert.AreEqual(-1, Divide(1, -1));
            Assert.AreEqual(9, Divide(29, 3));
        }
    };
}
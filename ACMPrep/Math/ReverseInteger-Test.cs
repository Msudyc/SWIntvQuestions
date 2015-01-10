using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class MathIntv
    {
        [TestMethod]
        public void MathIntv_ReverseTest1()
        {
            Assert.AreEqual(0, Reverse(0));
            Assert.AreEqual(2, Reverse(2));
            Assert.AreEqual(-2, Reverse(-2));
            Assert.AreEqual(123, Reverse(321));
            Assert.AreEqual(-123, Reverse(-321));
            Assert.AreEqual(1, Reverse(100));
        }
    };
}
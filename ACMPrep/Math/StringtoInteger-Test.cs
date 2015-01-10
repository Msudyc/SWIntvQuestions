using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class MathIntv
    {
        [TestMethod]
        public void MathIntv_AtoiTest1()
        {
            Assert.AreEqual(1234, Atoi("1234"));
            Assert.AreEqual(-1234, Atoi("-1234"));
            Assert.AreEqual(-1234, Atoi("    -1234"));
            Assert.AreEqual(0, Atoi("aaa-1234"));
            Assert.AreEqual(int.MaxValue, Atoi("2147483648"));
            Assert.AreEqual(int.MinValue, Atoi("-2147483649"));
            Assert.AreEqual(int.MaxValue, Atoi("    10522545459"));
            Assert.AreEqual(int.MinValue, Atoi("      -11919730356x"));
        }
    };
}
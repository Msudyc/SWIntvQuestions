using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class StringIntv
    {
        [TestMethod]
        public void StringIntv_RomanToIntTest1()
        {
            Assert.AreEqual(138, RomanToInt("CXXXVIII"));
            Assert.AreEqual(1996, RomanToInt("MCMXCVI"));
        }
    };
}
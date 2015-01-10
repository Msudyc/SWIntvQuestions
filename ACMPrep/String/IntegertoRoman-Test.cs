using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class StringIntv
    {
        [TestMethod]
        public void StringIntv_IntToRomanTest1()
        {
            Assert.AreEqual("IV", IntToRoman(4));
            Assert.AreEqual("VIII", IntToRoman(8));
            Assert.AreEqual("CXXXVIII", IntToRoman(138));
        }
    };
}
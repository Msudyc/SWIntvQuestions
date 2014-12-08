using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OTHR
{
    public partial class OTHREx
    {
        [TestMethod]
        public void OTHR_MoneyBreakTest1()
        {
            Assert.AreEqual("100 2 1 0.25 0.10 ", MoneyBreak(103.35m));
        }

        [TestMethod]
        public void OTHR_MoneyBreakTest2()
        {
            Assert.AreEqual("100 2 2 0.01 0.01 0.01 ", MoneyBreak(104.03m));
        }
    }
}

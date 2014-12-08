using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    [TestClass]
    public partial class AMZN
    {
        [TestMethod]
        public void AMZN_IsMultipleTest1()
        {
            Assert.IsTrue(IsMultiple("abcabcabc"));
            Assert.IsFalse(IsMultiple("bcdbcdbcde"));
            Assert.IsTrue(IsMultiple("abcdabcd"));
            Assert.IsFalse(IsMultiple("xyz"));
            Assert.IsFalse(IsMultiple("aaaaaaaaaa"));
        }
    }
}
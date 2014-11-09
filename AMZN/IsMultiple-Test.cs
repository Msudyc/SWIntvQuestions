using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AMZN
{
    [TestClass]
    public partial class String
    {
        [TestMethod]
        public void String_IsMultipleTest1()
        {
            Assert.IsTrue(IsMultiple("abcabcabc"));
            Assert.IsFalse(IsMultiple("bcdbcdbcde"));
            Assert.IsTrue(IsMultiple("abcdabcd"));
            Assert.IsFalse(IsMultiple("xyz"));
            Assert.IsFalse(IsMultiple("aaaaaaaaaa"));
        }
    }
}
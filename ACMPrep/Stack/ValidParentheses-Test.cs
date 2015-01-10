using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class StackIntv
    {
        [TestMethod]
        public void StackIntv_IsValidTest1()
        {
            string s = "()[]{}", s2 ="([)]";
            Assert.IsTrue(IsValid(s));
            Assert.IsFalse(IsValid(s2));
        }

        [TestMethod]
        public void StackIntv_IsValidTest2()
        {
            string s = "", s2 ="(()]";
            Assert.IsTrue(IsValid(s));
            Assert.IsFalse(IsValid(s2));
        }

        [TestMethod]
        public void StackIntv_IsValidTest3()
        {
            string s = "(((())))[{()}]", s2 ="(((())))[{(}]";
            Assert.IsTrue(IsValid(s));
            Assert.IsFalse(IsValid(s2));
        }
    };
}
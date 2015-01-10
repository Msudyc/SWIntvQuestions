using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class StackIntv
    {
        [TestMethod]
        public void StackIntv_LongestValidParenthesesTest1()
        {
            Assert.AreEqual(4, LongestValidParentheses(")()())"));
            Assert.AreEqual(2, LongestValidParentheses("()"));
            Assert.AreEqual(2, LongestValidParentheses("()(()"));
        }

        [TestMethod]
        public void StackIntv_LongestValidParenthesesTest2()
        {
            Assert.AreEqual(0, LongestValidParentheses(""));
            Assert.AreEqual(0, LongestValidParentheses("("));
            Assert.AreEqual(0, LongestValidParentheses(")"));
        }
    };
}
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FB
{
    public partial class FBEx
    {
        [TestMethod]
        public void FB_LongestPalindromeTest1()
        {
            string s = "abbac";
            Assert.AreEqual("abba", LongestPalindrome(s));
        }
    };
}
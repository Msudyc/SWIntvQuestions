using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class DynamicProgramming
    {
        [TestMethod]
        public void DynamicProgramming_LongestPalindromeTest1()
        {
            string s = "abbac";
            Assert.AreEqual("abba", LongestPalindrome(s));
        }

        [TestMethod]
        public void DynamicProgramming_LongestPalindromeTest2()
        {
            string s = "abbac";
            Assert.AreEqual("abba", LongestPalindrome1(s));
        }

        [TestMethod]
        public void DynamicProgramming_LongestPalindromeTest3()
        {
            string s = "abbac";
            Assert.AreEqual("abba", LongestPalindrome2(s));
        }

        [TestMethod]
        public void DynamicProgramming_LongestPalindromeTest4()
        {
            string s = "abbac";
            Assert.AreEqual("abba", LongestPalindrome3(s));
        }
    };
}
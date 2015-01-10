using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class TwoPointers
    {
        [TestMethod]
        public void TwoPointers_LengthOfLongestSubstringTest1()
        {
            string a = "abcbdebc";
            Assert.AreEqual(4, LengthOfLongestSubstring(a));
        }

        [TestMethod]
        public void TwoPointers_LengthOfLongestSubstringTest2()
        {
            string a = "bbbbbbbb";
            Assert.AreEqual(1, LengthOfLongestSubstring(a));
        }

        [TestMethod]
        public void TwoPointers_LengthOfLongestSubstringTest3()
        {
            string a = "";
            Assert.AreEqual(0, LengthOfLongestSubstring(a));
        }
    };
}
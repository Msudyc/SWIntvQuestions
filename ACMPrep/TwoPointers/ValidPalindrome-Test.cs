using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class TwoPointers
    {
        [TestMethod]
        public void TwoPointers_IsPalindromeTest1()
        {
            Assert.IsTrue(IsPalindrome("A man, a plan, a canal: Panama"));
        }

        [TestMethod]
        public void TwoPointers_IsPalindromeTest2()
        {
            Assert.IsFalse(IsPalindrome("A man, a plan, a canalc: Panama"));
        }

        [TestMethod]
        public void TwoPointers_IsPalindromeTest3()
        {
            Assert.IsTrue(IsPalindrome("   "));
        }

        [TestMethod]
        public void TwoPointers_IsPalindromeTest4()
        {
            Assert.IsTrue(IsPalindrome(" c "));
        }
    };
}
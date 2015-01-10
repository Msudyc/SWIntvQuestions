using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class MathIntv
    {
        [TestMethod]
        public void MathIntv_IsPalindromeTest1()
        {
            Assert.IsTrue(IsPalindrome(0));
            Assert.IsFalse(IsPalindrome(-12));
            Assert.IsTrue(IsPalindrome(121));
            Assert.IsFalse(IsPalindrome(1123));
            Assert.IsTrue(IsPalindrome(986121689));
            Assert.IsTrue(IsPalindrome(1001));
            Assert.IsTrue(IsPalindrome(1000110001));
        }

        [TestMethod]
        public void MathIntv_IsPalindromeTest2()
        {
            Assert.IsFalse(IsPalindrome(10));
        }
    };
}
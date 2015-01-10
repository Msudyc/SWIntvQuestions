using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class StringIntv
    {
        [TestMethod]
        public void StringIntv_IsOneEditDistanceTest1()
        {
            Assert.IsTrue(IsOneEditDistance("a", "ab"));
        }

        [TestMethod]
        public void StringIntv_IsOneEditDistanceTest2()
        {
            Assert.IsTrue(IsOneEditDistance("ac", "ab"));
        }

        [TestMethod]
        public void StringIntv_IsOneEditDistanceTest3()
        {
            Assert.IsFalse(IsOneEditDistance("a", "a"));
        }

        [TestMethod]
        public void StringIntv_IsOneEditDistanceTest4()
        {
            Assert.IsFalse(IsOneEditDistance("a", "abc"));
        }
    };
}
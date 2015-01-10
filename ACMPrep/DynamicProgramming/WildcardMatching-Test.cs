using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class DynamicProgramming
    {
        [TestMethod]
        public void DynamicProgramming_WildcardIsMatchTest1()
        {
            Assert.IsFalse(WildcardIsMatch("aa", "a"));
            Assert.IsTrue(WildcardIsMatch("aa", "a*"));
        }

        [TestMethod]
        public void DynamicProgramming_WildcardIsMatchTest2()
        {
            Assert.IsFalse(WildcardIsMatch("aa", "abb"));
        }

        [TestMethod]
        public void DynamicProgramming_WildcardIsMatchTest3()
        {
            Assert.IsTrue(WildcardIsMatch("aa", "a?"));
        }

        [TestMethod]
        public void DynamicProgramming_WildcardIsMatchTest4()
        {
            Assert.IsTrue(WildcardIsMatch("aabb", "a*"));
        }

        [TestMethod]
        public void DynamicProgramming_WildcardIsMatchTest5()
        {
            Assert.IsTrue(WildcardIsMatch("aabb", "a?*"));
        }

        [TestMethod]
        public void DynamicProgramming_WildcardIsMatchTest6()
        {
            Assert.IsFalse(WildcardIsMatch("aacbb", "a*c"));
        }
    };
}
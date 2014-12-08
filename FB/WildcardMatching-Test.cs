using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FB
{
    public partial class FBEx
    {
        [TestMethod]
        public void FB_IsWildMatch1()
        {
            Assert.IsFalse(IsWildMatch("aa", "a"));
            Assert.IsTrue(IsWildMatch("aa", "a*"));
        }

        [TestMethod]
        public void FB_IsWildMatch2()
        {
            Assert.IsFalse(IsWildMatch("aa", "abb"));
        }

        [TestMethod]
        public void FB_IsWildMatch3()
        {
            Assert.IsTrue(IsWildMatch("aa", "a?"));
        }

        [TestMethod]
        public void FB_IsWildMatch4()
        {
            Assert.IsTrue(IsWildMatch("aabb", "a*"));
        }

        [TestMethod]
        public void FB_IsWildMatch5()
        {
            Assert.IsTrue(IsWildMatch("aabb", "a?*"));
        }

        [TestMethod]
        public void FB_IsWildMatch6()
        {
            Assert.IsFalse(IsWildMatch("aacbb", "a*c"));
        }
    };
}
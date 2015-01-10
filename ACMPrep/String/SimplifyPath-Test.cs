using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class StringIntv
    {
        [TestMethod]
        public void StringIntv_SimplifyPathTest1()
        {
            Assert.AreEqual("/home", SimplifyPath("/home/"));
        }

        [TestMethod]
        public void StringIntv_SimplifyPathTest2()
        {
            Assert.AreEqual("/c", SimplifyPath("/a/./b/../../c/"));
        }

        [TestMethod]
        public void StringIntv_SimplifyPathTest3()
        {
            Assert.AreEqual("/home/foo", SimplifyPath("/home//foo/"));
        }

        [TestMethod]
        public void StringIntv_SimplifyPathTest4()
        {
            Assert.AreEqual("/home", SimplifyPath("/home"));
        }
    };
}
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class StringIntv
    {
        [TestMethod]
        public void StringIntv_CompareVersionTest1()
        {
            Assert.AreEqual(-1, CompareVersion("2.3.4", "2.3.67"));
        }

        [TestMethod]
        public void StringIntv_CompareVersionTest2()
        {
            Assert.AreEqual(0, CompareVersion("2.3", "2.3.0.0"));
        }

        [TestMethod]
        public void StringIntv_CompareVersionTest3()
        {
            Assert.AreEqual(1, CompareVersion("2.6", "2.3.0.0"));
        }
    };
}
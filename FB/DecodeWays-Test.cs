using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FB
{
    public partial class FBEx
    {
        [TestMethod]
        public void FB_NumDecodingsTest1()
        {
            Assert.AreEqual(2, NumDecodings("12"));
        }

        [TestMethod]
        public void FB_NumDecodingsTest2()
        {
            Assert.AreEqual(3, NumDecodings("123"));
        }

        [TestMethod]
        public void FB_NumDecodingsTest3()
        {
            Assert.AreEqual(1, NumDecodings("5"));
        }

        [TestMethod]
        public void FB_NumDecodingsTest4()
        {
            Assert.AreEqual(1, NumDecodings("567"));
        }

        [TestMethod]
        public void FB_NumDecodingsTest5()
        {
            Assert.AreEqual(2, NumDecodings("2343"));
        }
    };
}
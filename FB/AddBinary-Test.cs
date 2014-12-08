using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FB
{    
    public partial class FBEx
    {
        [TestMethod]
        public void FB_AddBinaryTest1()
        {
            Assert.AreEqual("101010110", AddBinary("11111111", "1010111"));
        }

        [TestMethod]
        public void FB_AddBinaryTest2()
        {
            Assert.AreEqual("10", AddBinary("1", "1"));
        }

        [TestMethod]
        public void FB_AddBinaryTest3()
        {
            Assert.AreEqual("0", AddBinary("0", "0"));
        }

        [TestMethod]
        public void FB_AddBinaryTest4()
        {
            Assert.AreEqual("1", AddBinary("1", "0"));
        }
    };
}
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class DynamicProgramming
    {
        [TestMethod]
        public void DynamicProgramming_NumDecodingsTest1()
        {
            Assert.AreEqual(2, NumDecodings("12"));
        }

        [TestMethod]
        public void DynamicProgramming_NumDecodingsTest2()
        {
            Assert.AreEqual(3, NumDecodings("123"));
        }

        [TestMethod]
        public void DynamicProgramming_NumDecodingsTest3()
        {
            Assert.AreEqual(1, NumDecodings("5"));
        }

        [TestMethod]
        public void DynamicProgramming_NumDecodingsTest4()
        {
            Assert.AreEqual(1, NumDecodings("567"));
        }

        [TestMethod]
        public void DynamicProgramming_NumDecodingsTest5()
        {
            Assert.AreEqual(2, NumDecodings("2343"));
        }
    };
}
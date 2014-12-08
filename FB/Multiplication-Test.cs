using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FB
{
    public partial class FBEx
    {
        [TestMethod]
        public void FB_MultiplicationTest1()
        {
            int[] test = { 1, 2, 3, 4, 5 };
            int[] result = Multiplication(test);
            Assert.AreEqual(120, result[0]);
            Assert.AreEqual(60, result[1]);
            Assert.AreEqual(40, result[2]);
            Assert.AreEqual(30, result[3]);
            Assert.AreEqual(24, result[4]);
        }
    }
}

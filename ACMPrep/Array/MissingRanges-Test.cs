using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class ArrayIntv
    {
        [TestMethod]
        public void ArrayIntv_FindMissingRangesTest1()
        {
            int[] test = { 0, 1, 3, 50, 75 };
            List<string> result = FindMissingRanges(test, 0, 99);
            Assert.AreEqual("2", result[0]);
            Assert.AreEqual("4->49", result[1]);
            Assert.AreEqual("51->74", result[2]);
            Assert.AreEqual("76->99", result[3]);
        }
    };
}
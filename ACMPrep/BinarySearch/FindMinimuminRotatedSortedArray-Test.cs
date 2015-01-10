using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    [TestClass]
    public partial class BinarySearch
    {
        [TestMethod]
        public void BinarySearch_FindMinTest1()
        {
            int[] num = { 4, 5, 6, 7, 0, 1, 2 };
            Assert.AreEqual(0, FindMin(num));
        }
    };
}
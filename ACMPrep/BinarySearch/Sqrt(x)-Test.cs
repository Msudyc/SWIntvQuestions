using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class BinarySearch
    {
        [TestMethod]
        public void BinarySearch_SqrtTest1()
        {
            Assert.AreEqual(7, Sqrt(49));
        }

        [TestMethod]
        public void BinarySearch_SqrtTest2()
        {
            Assert.AreEqual(1, Sqrt(1));
        }

        [TestMethod]
        public void BinarySearch_SqrtTest3()
        {
            Assert.AreEqual(10, Sqrt(100));
        }

        [TestMethod]
        public void BinarySearch_SqrtTest4()
        {
            Assert.AreEqual(5, Sqrt(25));
        }
    };
}
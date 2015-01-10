using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class MathIntv
    {
        [TestMethod]
        public void MathIntv_ConvertToTitleTest1()
        {
            Assert.AreEqual("AB", ConvertToTitle(28));
            Assert.AreEqual("BAA", ConvertToTitle(1379));
        }

        [TestMethod]
        public void MathIntv_ConvertToTitleTest2()
        {
            Assert.AreEqual("C", ConvertToTitleFromZero(2));
        }

        [TestMethod]
        public void MathIntv_ConvertToTitleTest3()
        {
            Assert.AreEqual("AC", ConvertToTitleFromZero(28));
        }

        [TestMethod]
        public void MathIntv_ConvertToTitleTest4()
        {
            Assert.AreEqual("BAB", ConvertToTitleFromZero(1379));
        }
    };
}
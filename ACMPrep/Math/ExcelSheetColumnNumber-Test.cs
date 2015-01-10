using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class MathIntv
    {
        [TestMethod]
        public void MathIntv_TitleToNumberTest1()
        {
            Assert.AreEqual(28, TitleToNumber("AB"));
        }

        [TestMethod]
        public void MathIntv_TitleToNumberTest2()
        {
            Assert.AreEqual(27, TitleToNumberFromZero("AB"));
        }

        [TestMethod]
        public void MathIntv_TitleToNumberTest3()
        {
            Assert.AreEqual(702, TitleToNumberFromZero("AAA"));
        }

        [TestMethod]
        public void MathIntv_TitleToNumberTest4()
        {
            Assert.AreEqual(1379, TitleToNumberFromZero("BAB"));
        }
    };
}
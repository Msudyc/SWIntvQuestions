using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    [TestClass]
    public partial class StackIntv
    {
        [TestMethod]
        public void StackIntv_DecimalToHexTest1()
        {
            Assert.AreEqual("96", DecimalToHex(150));
        }

        [TestMethod]
        public void StackIntv_DecimalToHexTest2()
        {
            Assert.AreEqual("0", DecimalToHex(0));
        }

        [TestMethod]
        public void StackIntv_DecimalToHexTest3()
        {
            Assert.AreEqual("-96", DecimalToHex(-150));
        }

        [TestMethod]
        public void StackIntv_DecimalToHexTest4()
        {
            Assert.AreEqual("BE", DecimalToHex(190));
        }
    }
}

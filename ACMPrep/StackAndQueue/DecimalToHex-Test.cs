using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    [TestClass]
    public partial class StackAndQueue
    {
        [TestMethod]
        public void StackAndQueue_DecimalToHexTest1()
        {
            Assert.AreEqual("96", DecimalToHex(150));
        }

        [TestMethod]
        public void StackAndQueue_DecimalToHexTest2()
        {
            Assert.AreEqual("0", DecimalToHex(0));
        }

        [TestMethod]
        public void StackAndQueue_DecimalToHexTest3()
        {
            Assert.AreEqual("-96", DecimalToHex(-150));
        }

        [TestMethod]
        public void StackAndQueue_DecimalToHexTest4()
        {
            Assert.AreEqual("BE", DecimalToHex(190));
        }
    }
}

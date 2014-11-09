using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class StackAndQueue
    {
        [TestMethod]
        public void StackAndQueue_DecimalToOctalTest1()
        {
            Assert.AreEqual("170", DecimalToOctal(120));
        }

        [TestMethod]
        public void StackAndQueue_DecimalToOctalTest2()
        {
            Assert.AreEqual("0", DecimalToOctal(0));
        }

        [TestMethod]
        public void StackAndQueue_DecimalToOctalTest3()
        {
            Assert.AreEqual("-170", DecimalToOctal(-120));
        }
    }
}

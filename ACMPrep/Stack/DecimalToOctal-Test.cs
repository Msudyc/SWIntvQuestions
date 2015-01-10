using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class StackIntv
    {
        [TestMethod]
        public void StackIntv_DecimalToOctalTest1()
        {
            Assert.AreEqual("170", DecimalToOctal(120));
        }

        [TestMethod]
        public void StackIntv_DecimalToOctalTest2()
        {
            Assert.AreEqual("0", DecimalToOctal(0));
        }

        [TestMethod]
        public void StackIntv_DecimalToOctalTest3()
        {
            Assert.AreEqual("-170", DecimalToOctal(-120));
        }
    }
}

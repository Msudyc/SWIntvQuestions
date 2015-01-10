using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class StackIntv
    {
        [TestMethod]
        public void StackIntv_HexToDecimalTest1()
        {
            Assert.AreEqual(150, HexToDecimal("96"));
        }

        [TestMethod]
        public void StackIntv_HexToDecimalTest2()
        {
            Assert.AreEqual(0, HexToDecimal("0"));
        }

        [TestMethod]
        public void StackIntv_HexToDecimalTest3()
        {
            Assert.AreEqual(-150, HexToDecimal("-96"));
        }

        [TestMethod]
        public void StackIntv_HexToDecimalTest4()
        {
            Assert.AreEqual(190, HexToDecimal("BE"));
        }
    }
}

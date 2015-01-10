using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class HashTable
    {
        [TestMethod]
        public void HashTable_FractionToDecimalTest1()
        {
            Assert.AreEqual("0.5", FractionToDecimal(1, 2));
        }

        [TestMethod]
        public void HashTable_FractionToDecimalTest2()
        {
            Assert.AreEqual("1.(3)", FractionToDecimal(4, 3));
        }
    };
}
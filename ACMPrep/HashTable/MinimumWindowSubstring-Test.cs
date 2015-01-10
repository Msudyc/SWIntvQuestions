using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class HashTable
    {
        [TestMethod]
        public void HashTable_MinWindowTest1()
        {
            Assert.AreEqual("BANC", MinWindow("ADOBECODEBANC", "ABC"));
        }

        [TestMethod]
        public void HashTable_MinWindowTest2()
        {
            Assert.AreEqual("", MinWindow("ABCDEFG", "XYZ"));
        }

        [TestMethod]
        public void HashTable_MinWindowTest3()
        {
            Assert.AreEqual("A", MinWindow("A", "A"));
        }

        [TestMethod]
        public void HashTable_MinWindowTest4()
        {
            Assert.AreEqual("BAC", MinWindow("GBACDEF", "BC"));
        }
    };
}
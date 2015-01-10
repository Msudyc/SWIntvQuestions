using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class Backtracking
    {
        [TestMethod]
        public void Backtracking_PartitionTest1()
        {
            List<List<string>> res = Partition("aab");
            Assert.AreEqual(2, res.Count);
        }

        [TestMethod]
        public void Backtracking_PartitionTest2()
        {
            List<List<string>> res = Partition("aa");
            Assert.AreEqual(2, res.Count);
        }

        [TestMethod]
        public void Backtracking_PartitionTest3()
        {
            List<List<string>> res = Partition("a");
            Assert.AreEqual(1, res.Count);
        }

        [TestMethod]
        public void Backtracking_PartitionTest4()
        {
            List<List<string>> res = Partition("");
            Assert.AreEqual(1, res.Count);
        }
    };
}
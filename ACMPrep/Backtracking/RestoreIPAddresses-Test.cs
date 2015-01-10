using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class Backtracking
    {
        [TestMethod]
        public void Backtracking_RestoreIpAddressesTest1()
        {
            List<string> r = RestoreIpAddresses("25525511135");
            Assert.AreEqual(2, r.Count);
        }

        [TestMethod]
        public void Backtracking_RestoreIpAddressesTest2()
        {
            List<string> r = RestoreIpAddresses("26525511135");
            Assert.AreEqual(0, r.Count);
        }

        [TestMethod]
        public void Backtracking_RestoreIpAddressesTest3()
        {
            List<string> r = RestoreIpAddresses("11125511135");
            Assert.AreEqual(2, r.Count);
        }

        [TestMethod]
        public void Backtracking_RestoreIpAddressesTest4()
        {
            List<string> r = RestoreIpAddresses("5525511135");
            Assert.AreEqual(2, r.Count);
        }
    };
}
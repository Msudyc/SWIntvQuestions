using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    [TestClass]
    public partial class LKTN
    {
        [TestMethod]
        public void LKTN_NestedListSumTest1()
        {
            Assert.AreEqual(10, NestedListSum("{{1, 1}, 2, {1, 1}}"));
        }

        [TestMethod]
        public void LKTN_NestedListSumTest2()
        {
            Assert.AreEqual(27, NestedListSum("{1, {4, {6}}}"));
        }
    }
}

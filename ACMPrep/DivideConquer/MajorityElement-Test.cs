using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    [TestClass]
    public partial class DivideConquer
    {
        [TestMethod]
        public void DivideConquer_MajorityElementTest1()
        {
            int[] test = {1, 2, 3, 5, 3, 3, 2, 3, 1, 3, 3, 3, 4, 3, 1};
            Assert.AreEqual(3, MajorityElement(test));
        }
    };
}
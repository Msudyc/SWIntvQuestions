using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class MathIntv
    {
        [TestMethod]
        public void MathIntv_GetPermutationTest1()
        {
            string r = GetPermutation(4, 5);
            Assert.AreEqual("1423", r);
        }

        [TestMethod]
        public void MathIntv_GetPermutationTest2()
        {
            string r = GetPermutation(1, 1);
            Assert.AreEqual("1", r);
        }

        [TestMethod]
        public void MathIntv_GetPermutationTest3()
        {
            string r = GetPermutation(2, 1);
            Assert.AreEqual("12", r);
        }
    };
}
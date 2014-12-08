using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class AMZN
    {
        [TestMethod]
        public void AMZN_MiceAndHolesTest1()
        {
            int[] mice = { 1, 3 };
            int[] holes = { 0, 1, 2 };
            Assert.AreEqual(1, MiceAndHoles(mice, holes));
        }

        [TestMethod]
        public void AMZN_MiceAndHolesTest2()
        {
            int[] mice = { 1, 3, 5 };
            int[] holes = { 2, 1, 0 };
            Assert.AreEqual(3, MiceAndHoles(mice, holes));
        }

        [TestMethod]
        public void AMZN_MiceAndHolesTest3()
        {
            int[] mice = { 1 };
            int[] holes = { 2, 1, 0 };
            Assert.AreEqual(0, MiceAndHoles(mice, holes));
        }

        [TestMethod]
        public void AMZN_MiceAndHolesTest4()
        {
            int[] mice = { 1, 2 };
            int[] holes = { 4, 6, 0 };
            Assert.AreEqual(2, MiceAndHoles(mice, holes));
        }
    }
}

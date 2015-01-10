using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    [TestClass]
    public partial class DynamicProgramming
    {
        [TestMethod]
        public void DynamicProgramming_ClimbStairsTest1()
        {
            Assert.AreEqual(55, ClimbStairs(9));
        }

        [TestMethod]
        public void DynamicProgramming_ClimbStairsTest2()
        {
            Assert.AreEqual(1, ClimbStairs(1));
        }

        [TestMethod]
        public void DynamicProgramming_ClimbStairsTest3()
        {
            Assert.AreEqual(2, ClimbStairs(2));
        }

        [TestMethod]
        public void DynamicProgramming_ClimbStairsTest4()
        {
            Assert.AreEqual(5, ClimbStairs(4));
        }

        [TestMethod]
        public void DynamicProgramming_ClimbStairsTest5()
        {
            Assert.AreEqual(34, ClimbStairs(8));
        }
    };
}
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FB
{
    public partial class FBEx
    {
        [TestMethod]
        public void FB_ContiguousSubSequenceSumTest1()
        {
            int[] test = { 2, -1, 0, 3, 4, 7};
            Assert.IsTrue(ContiguousSubSequenceSum(test, 2));
        }

        [TestMethod]
        public void FB_ContiguousSubSequenceSumTest2()
        {
            int[] test = { 2, -1, 0, 5, 4, 7 };
            Assert.IsFalse(ContiguousSubSequenceSum(test, 2));
        }
    }
}

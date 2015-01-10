using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class DynamicProgramming
    {
        [TestMethod]
        public void DynamicProgramming_IsInterleaveTest1()
        {
            Assert.IsTrue(IsInterleave("ace", "bdf", "abcdef"));
        }

        [TestMethod]
        public void DynamicProgramming_IsInterleaveTest2()
        {
            Assert.IsFalse(IsInterleave("ake", "bdf", "abcdef"));
        }

        [TestMethod]
        public void DynamicProgramming_IsInterleaveTest3()
        {
            Assert.IsTrue(IsInterleave("a", "b", "ba"));
        }

        [TestMethod]
        public void DynamicProgramming_IsInterleaveTest4()
        {
            Assert.IsTrue(IsInterleave("", "", ""));
        }

        [TestMethod]
        public void DynamicProgramming_IsInterleaveTest5()
        {
            Assert.IsTrue(IsInterleave("a", "", "a"));
        }

        [TestMethod]
        public void DynamicProgramming_IsInterleaveTest6()
        {
            Assert.IsFalse(IsInterleave("ab", "cd", "dcab"));
        }
    };
}
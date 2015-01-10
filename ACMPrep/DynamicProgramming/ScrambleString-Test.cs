using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class DynamicProgramming
    {
        [TestMethod]
        public void DynamicProgramming_IsScrambleTest1()
        {
            Assert.IsTrue(IsScramble("great", "rgaet"));
        }

        [TestMethod]
        public void DynamicProgramming_IsScrambleTest2()
        {
            Assert.IsTrue(IsScramble("ab", "ba"));
        }

        [TestMethod]
        public void DynamicProgramming_IsScrambleTest3()
        {
            Assert.IsTrue(IsScramble("a", "a"));
        }

        [TestMethod]
        public void DynamicProgramming_IsScrambleTest4()
        {
            Assert.IsFalse(IsScramble("breat", "rgaet"));
        }

        [TestMethod]
        public void DynamicProgramming_IsScrambleTest5()
        {
            Assert.IsFalse(IsScramble("b", "c"));
        }

        [TestMethod]
        public void DynamicProgramming_IsScrambleTest6()
        {
            Assert.IsTrue(IsScramble1("great", "rgaet"));
        }

        [TestMethod]
        public void DynamicProgramming_IsScrambleTest7()
        {
            Assert.IsTrue(IsScramble1("ab", "ba"));
        }

        [TestMethod]
        public void DynamicProgramming_IsScrambleTest8()
        {
            Assert.IsTrue(IsScramble1("a", "a"));
        }

        [TestMethod]
        public void DynamicProgramming_IsScrambleTest9()
        {
            Assert.IsFalse(IsScramble1("breat", "rgaet"));
        }

        [TestMethod]
        public void DynamicProgramming_IsScrambleTest10()
        {
            Assert.IsFalse(IsScramble1("b", "c"));
        }
    };
}
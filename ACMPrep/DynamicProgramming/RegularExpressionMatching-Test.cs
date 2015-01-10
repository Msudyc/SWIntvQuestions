using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class DynamicProgramming
    {
        [TestMethod]
        public void DynamicProgramming_IsMatchTest1()
        {
            Assert.IsFalse(RegularExpressionIsMatch("aa", "a"));
            Assert.IsFalse(RegularExpressionIsMatch("aaa", "aa"));
            Assert.IsTrue(RegularExpressionIsMatch("aa", "aa"));
            Assert.IsTrue(RegularExpressionIsMatch("aa", "a*"));
            Assert.IsTrue(RegularExpressionIsMatch("aa", ".*"));
            Assert.IsTrue(RegularExpressionIsMatch("ab", ".*"));
            Assert.IsTrue(RegularExpressionIsMatch("aab", "c*a*b"));
            Assert.IsFalse(RegularExpressionIsMatch("aab", "ddc*a*b"));
            Assert.IsFalse(RegularExpressionIsMatch("", "c"));
        }

        [TestMethod]
        public void DynamicProgramming_IsMatchTest2()
        {
            Assert.IsTrue(RegularExpressionIsMatch("abcdxyzda", "a.*da"));
        }

        [TestMethod]
        public void DynamicProgramming_IsMatchTest3()
        {
            Assert.IsTrue(RegularExpressionIsMatch("abcdxyzdakadyda", "a.*da"));
        }

        [TestMethod]
        public void DynamicProgramming_IsMatchTest4()
        {
            Assert.IsFalse(RegularExpressionIsMatch("abcdxyzdakadyd", "a.*da"));
        }

        [TestMethod]
        public void DynamicProgramming_IsMatchTest5()
        {
            Assert.IsTrue(RegularExpressionIsMatch("abcdxyzdakadyd", "a.*da.*"));
        }

        [TestMethod]
        public void DynamicProgramming_IsMatchTest6()
        {
            Assert.IsFalse(RegularExpressionIsMatch("abcdxyzdakadyda", "a.*da.*d"));
        }

        [TestMethod]
        public void DynamicProgramming_IsMatchTest7()
        {
            Assert.IsTrue(RegularExpressionIsMatch("abcdayzdakadaxxdattd", "a.*da.*d"));
        }

        [TestMethod]
        public void DynamicProgramming_IsMatchTest8()
        {
            Assert.IsFalse(RegularExpressionIsMatch("abcdayzdakadaxxdattda", "a.*da.*d"));
        }

        //---

        [TestMethod]
        public void DynamicProgramming_IsMatchATest1()
        {
            Assert.IsFalse(RegularExpressionIsMatchDP("aa", "a"));
            Assert.IsFalse(RegularExpressionIsMatchDP("aaa", "aa"));
            Assert.IsTrue(RegularExpressionIsMatchDP("aa", "aa"));
            Assert.IsTrue(RegularExpressionIsMatchDP("aa", "a*"));
            Assert.IsTrue(RegularExpressionIsMatchDP("aa", ".*"));
            Assert.IsTrue(RegularExpressionIsMatchDP("ab", ".*"));
            Assert.IsTrue(RegularExpressionIsMatchDP("aab", "c*a*b"));
            Assert.IsFalse(RegularExpressionIsMatchDP("aab", "ddc*a*b"));
            Assert.IsFalse(RegularExpressionIsMatchDP("", "c"));
        }

        [TestMethod]
        public void DynamicProgramming_IsMatchATest2()
        {
            Assert.IsTrue(RegularExpressionIsMatchDP("abcdxyzda", "a.*da"));
        }

        [TestMethod]
        public void DynamicProgramming_IsMatchATest3()
        {
            Assert.IsTrue(RegularExpressionIsMatchDP("abcdxyzdakadyda", "a.*da"));
        }

        [TestMethod]
        public void DynamicProgramming_IsMatchATest4()
        {
            Assert.IsFalse(RegularExpressionIsMatchDP("abcdxyzdakadyd", "a.*da"));
        }

        [TestMethod]
        public void DynamicProgramming_IsMatchATest5()
        {
            Assert.IsTrue(RegularExpressionIsMatchDP("abcdxyzdakadyd", "a.*da.*"));
        }

        [TestMethod]
        public void DynamicProgramming_IsMatchATest6()
        {
            Assert.IsFalse(RegularExpressionIsMatchDP("abcdxyzdakadyda", "a.*da.*d"));
        }

        [TestMethod]
        public void DynamicProgramming_IsMatchATest7()
        {
            Assert.IsTrue(RegularExpressionIsMatchDP("abcdayzdakadaxxdattd", "a.*da.*d"));
        }

        [TestMethod]
        public void DynamicProgramming_IsMatchATest8()
        {
            Assert.IsFalse(RegularExpressionIsMatchDP("abcdayzdakadaxxdattda", "a.*da.*d"));
        }

        [TestMethod]
        public void DynamicProgramming_IsMatchATest9()
        {
            Assert.IsTrue(RegularExpressionIsMatchDP("aaa", "a*a"));
        }

        [TestMethod]
        public void DynamicProgramming_IsMatchATest10()
        {
            Assert.IsTrue(RegularExpressionIsMatchDP("aaa", "ab*a*c*a"));
        }

        [TestMethod]
        public void DynamicProgramming_IsMatchATest11()
        {
            Assert.IsFalse(RegularExpressionIsMatchDP("*", "*"));
        }
    };
}
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class Backtracking
    {
        [TestMethod]
        public void Backtracking_GenerateParenthesisTest1()
        {
            List<string> r = GenerateParenthesis(3);
            Assert.AreEqual(5, r.Count);
        }

        [TestMethod]
        public void Backtracking_GenerateParenthesisTest2()
        {
            List<string> r = GenerateParenthesis(1);
            Assert.AreEqual(1, r.Count);
        }

        [TestMethod]
        public void Backtracking_GenerateParenthesisTest3()
        {
            List<string> r = GenerateParenthesis(2);
            Assert.AreEqual(2, r.Count);
        }
    };
}
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class StackIntv
    {
        [TestMethod]
        public void StackIntv_EvalRPNTest1()
        {
            List<string> t = new List<string>();
            t.Add("2");
            t.Add("1");
            t.Add("+");
            t.Add("3");
            t.Add("*");
            Assert.AreEqual(9, EvalRPN(t));
        }

        [TestMethod]
        public void StackIntv_EvalRPNTest2()
        {
            List<string> t = new List<string>();
            t.Add("4");
            t.Add("13");
            t.Add("5");
            t.Add("/");
            t.Add("+");
            Assert.AreEqual(6, EvalRPN(t));
        }
    };
}
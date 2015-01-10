using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class StringIntv
    {
        [TestMethod]
        public void StringIntv_IsNumberTest1()
        {
            Assert.IsFalse(IsNumber("aaa"));
        }

        [TestMethod]
        public void StringIntv_IsNumberTest2()
        {
            Assert.IsTrue(IsNumber("110.1123"));
        }

        [TestMethod]
        public void StringIntv_IsNumberTest3()
        {
            Assert.IsFalse(IsNumber("10a"));
        }

        [TestMethod]
        public void StringIntv_IsNumberTest4()
        {
            Assert.IsTrue(IsNumber("001.e3"));
        }

        [TestMethod]
        public void StringIntv_IsNumberTest5()
        {
            Assert.IsFalse(IsNumber("1e345.1123"));
        }

        [TestMethod]
        public void StringIntv_IsNumberTest6()
        {
            Assert.IsFalse(IsNumber2("aaa"));
        }

        [TestMethod]
        public void StringIntv_IsNumberTest7()
        {
            Assert.IsTrue(IsNumber2("110.1123"));
        }

        [TestMethod]
        public void StringIntv_IsNumberTest8()
        {
            Assert.IsFalse(IsNumber2("10a"));
        }

        [TestMethod]
        public void StringIntv_IsNumberTest9()
        {
            Assert.IsTrue(IsNumber2("001.e3"));
        }

        [TestMethod]
        public void StringIntv_IsNumberTest10()
        {
            Assert.IsFalse(IsNumber2("1e345.1123"));
        }
    };
}
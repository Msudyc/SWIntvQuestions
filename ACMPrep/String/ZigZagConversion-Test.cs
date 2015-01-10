using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class StringIntv
    {
        [TestMethod]
        public void StringIntv_ConvertTest1()
        {
            string s = "PAYPALISHIRING";
            string r = "PAHNAPLSIIGYIR";
            Assert.AreEqual(r, Convert(s, 3));
        }

        [TestMethod]
        public void StringIntv_ConvertTest2()
        {
            string s = "PAYPALISHIRING";
            string r = "PINALSIGYAHRPI";
            Assert.AreEqual(r, Convert(s, 4));
        }

        [TestMethod]
        public void StringIntv_ConvertTest3()
        {
            string s = "";
            string r = "";
            Assert.AreEqual(r, Convert(s, 4));
        }

        [TestMethod]
        public void StringIntv_ConvertTest4()
        {
            string s = "P";
            string r = "P";
            Assert.AreEqual(r, Convert(s, 4));
        }
    };
}
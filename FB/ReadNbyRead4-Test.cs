using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FB
{
    public partial class FBEx
    {
        [TestMethod]
        public void FB_ReadNbyRead4Test1()
        {
            char[] test = { '0', '1', '2', '3', '4', '5', '6' };
            char[] res = new char[5];
            FBExReadN r = new FBExReadN(test);
            Assert.AreEqual(5, r.ReadNbyRead4(res, 5));
            Assert.AreEqual('0', res[0]);
            Assert.AreEqual('1', res[1]);
            Assert.AreEqual('2', res[2]);
            Assert.AreEqual('3', res[3]);
            Assert.AreEqual('4', res[4]);
        }

        [TestMethod]
        public void FB_ReadNbyRead4Test2()
        {
            char[] test = { '0', '1', '2', '3', '4', '5', '6' };
            char[] res = new char[9];
            FBExReadN r = new FBExReadN(test);
            Assert.AreEqual(7, r.ReadNbyRead4(res, 9));
            Assert.AreEqual('0', res[0]);
            Assert.AreEqual('1', res[1]);
            Assert.AreEqual('2', res[2]);
            Assert.AreEqual('3', res[3]);
            Assert.AreEqual('4', res[4]);
            Assert.AreEqual('5', res[5]);
            Assert.AreEqual('6', res[6]);
            Assert.AreEqual(0, res[7]);
        }
    }
}

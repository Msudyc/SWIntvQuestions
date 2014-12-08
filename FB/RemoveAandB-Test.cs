using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FB
{
    public partial class FBEx
    {
        [TestMethod]
        public void FB_RemoveAandBTest1()
        {
            char[] test = { 'a', 'c', 'b', 'b', 'c', 'a' };
            RemoveAandB(test);
            Assert.AreEqual('c', test[0]);
            Assert.AreEqual('c', test[1]);
            Assert.AreEqual('\0', test[2]);
            Assert.AreEqual('\0', test[3]);
            Assert.AreEqual('\0', test[4]);
            Assert.AreEqual('\0', test[5]);
        }
    }
}

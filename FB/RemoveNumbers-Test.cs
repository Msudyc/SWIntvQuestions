using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FB
{
    public partial class FBEx
    {
        [TestMethod]
        public void FB_RemoveNumbersTest1()
        {
            Assert.AreEqual(8, RemoveNumbers(8));
        }
    }
}

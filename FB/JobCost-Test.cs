using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FB
{
    public partial class FBEx
    {
        [TestMethod]
        public void FB_JobCostsTest1()
        {
            Assert.AreEqual(8, JobCosts(8));
        }
    }
}

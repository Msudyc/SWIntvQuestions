using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    [TestClass]
    public partial class DFS
    {
        [TestMethod]
        public void DFS_GetAllSubSetsTest1()
        {
            char[] test = { 'A', 'B', 'C' };
            List<List<char>> result = GetAllSubSets(test);
            Assert.AreEqual(8, result.Count);
        }
    }
}

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class DynamicProgramming
    {
        [TestMethod]
        public void DynamicProgramming_GenerateTreesTest1()
        {
            List<TreeNode> r = GenerateTrees(3);
            Assert.AreEqual(5, r.Count);
        }

        [TestMethod]
        public void DynamicProgramming_GenerateTreesTest2()
        {
            List<TreeNode> r = GenerateTrees(1);
            Assert.AreEqual(1, r.Count);
            Assert.IsNotNull(r[0]);
        }

        [TestMethod]
        public void DynamicProgramming_GenerateTreesTest3()
        {
            List<TreeNode> r = GenerateTrees(0);
            Assert.AreEqual(1, r.Count);
            Assert.IsNull(r[0]);
        }

        [TestMethod]
        public void DynamicProgramming_GenerateTreesTest4()
        {
            List<TreeNode> r = GenerateTrees(4);
            Assert.AreEqual(14, r.Count);
        }
    };
}
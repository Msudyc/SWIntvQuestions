using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACMPrep;

namespace FB
{
    public partial class FBEx
    {
        [TestMethod]
        public void FB_RootToLeafPathsTest1()
        {
            TreeNode root = new TreeNode(1),
                l = new TreeNode(2),
                r = new TreeNode(3),
                rl = new TreeNode(4),
                rr = new TreeNode(5);
            root.Left = l;
            root.Right = r;
            r.Left = rl;
            r.Right = rr;
            List<string> result = RootToLeafPaths(root);
            Assert.AreEqual(3, result.Count);
            Assert.IsTrue(result.Contains("12"));
            Assert.IsTrue(result.Contains("134"));
            Assert.IsTrue(result.Contains("135"));
        }

        [TestMethod]
        public void FB_RootToLeafPathsTest2()
        {
            TreeNode root = new TreeNode(1),
                l = new TreeNode(2),
                r = new TreeNode(3);
            root.Left = l;
            root.Right = r;
            List<string> result = RootToLeafPaths(root);
            Assert.AreEqual(2, result.Count);
            Assert.IsTrue(result.Contains("12"));
            Assert.IsTrue(result.Contains("13"));
        }

        [TestMethod]
        public void FB_RootToLeafPathsTest3()
        {
            TreeNode root = new TreeNode(1);
            List<string> result = RootToLeafPaths(root);
            Assert.AreEqual(1, result.Count);
            Assert.IsTrue(result.Contains("1"));
        }
    }
}

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class TreeIntv
    {
        [TestMethod]
        public void TreeIntv_MinDepthTest1()
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
            Assert.AreEqual(2, MinDepth(root));
        }

        [TestMethod]
        public void TreeIntv_MinDepthTest2()
        {
            TreeNode root = new TreeNode(1);
            Assert.AreEqual(1, MinDepth(root));
        }
    };
}
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class TreeIntv
    {
        [TestMethod]
        public void TreeIntv_MaxDepthTest1()
        {
            TreeNode root = new TreeNode(1),
                l = new TreeNode(2),
                r = new TreeNode(3),
                rl = new TreeNode(4),
                rr = new TreeNode(5),
                rrr = new TreeNode(6);
            root.Left = l;
            root.Right = r;
            r.Left = rl;
            r.Right = rr;
            rr.Right = rrr;
            Assert.AreEqual(4, MaxDepth(root));
        }

        [TestMethod]
        public void TreeIntv_MaxDepthTest2()
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
            Assert.AreEqual(3, MaxDepth(root));
        }

        [TestMethod]
        public void TreeIntv_MaxDepthTest3()
        {
            TreeNode root = new TreeNode(1);
            Assert.AreEqual(1, MaxDepth(root));
        }

        [TestMethod]
        public void TreeIntv_MaxDepthTest4()
        {
            TreeNode root = new TreeNode(1),
                l = new TreeNode(2),
                r = new TreeNode(3),
                rl = new TreeNode(4),
                rr = new TreeNode(5),
                rrr = new TreeNode(6);
            root.Left = l;
            root.Right = r;
            r.Left = rl;
            r.Right = rr;
            rr.Right = rrr;
            Assert.AreEqual(4, MaxDepthNR(root));
        }

        [TestMethod]
        public void TreeIntv_MaxDepthTest5()
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
            Assert.AreEqual(3, MaxDepthNR(root));
        }

        [TestMethod]
        public void TreeIntv_MaxDepthTest6()
        {
            TreeNode root = new TreeNode(1);
            Assert.AreEqual(1, MaxDepthNR(root));
        }
    };
}
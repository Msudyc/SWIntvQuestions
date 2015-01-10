using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class TreeIntv
    {
        [TestMethod]
        public void TreeIntv_HasPathSumTest1()
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
            Assert.IsTrue(HasPathSum(root, 8));
        }

        [TestMethod]
        public void TreeIntv_HasPathSumTest2()
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
            Assert.IsFalse(HasPathSum(root, 10));
        }

        [TestMethod]
        public void TreeIntv_HasPathSumTest3()
        {
            TreeNode root = new TreeNode(1);
            Assert.IsTrue(HasPathSum(root, 1));
        }

        [TestMethod]
        public void TreeIntv_HasPathSumTest4()
        {
            TreeNode root = new TreeNode(1);
            Assert.IsFalse(HasPathSum(root, 2));
        }
    };
}
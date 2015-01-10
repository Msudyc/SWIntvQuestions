using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class TreeIntv
    {
        [TestMethod]
        public void TreeIntv_PathSumTest1()
        {
            TreeNode root = new TreeNode(1),
                l = new TreeNode(2),
                r = new TreeNode(3),
                rl = new TreeNode(4),
                rr = new TreeNode(5);
            root.Left = l; root.Right = r;
            r.Left = rl; r.Right = rr;
            List<List<int>> res = PathSum(root, 8);
            Assert.AreEqual(1, res.Count);
        }

        [TestMethod]
        public void TreeIntv_PathSumTest2()
        {
            TreeNode root = new TreeNode(1),
                l = new TreeNode(2),
                r = new TreeNode(3),
                rl = new TreeNode(4),
                rr = new TreeNode(5),
                ll = new TreeNode(6);
            root.Left = l; root.Right = r;
            r.Left = rl; r.Right = rr; l.Left = ll;
            List<List<int>> res = PathSum(root, 9);
            Assert.AreEqual(2, res.Count);
        }

        [TestMethod]
        public void TreeIntv_PathSumTest3()
        {
            TreeNode root = new TreeNode(1),
                l = new TreeNode(2),
                r = new TreeNode(3),
                rl = new TreeNode(4),
                rr = new TreeNode(5);
            root.Left = l; root.Right = r;
            r.Left = rl; r.Right = rr;
            List<List<int>> res = PathSum(root, 10);
            Assert.AreEqual(0, res.Count);
        }
    };
}
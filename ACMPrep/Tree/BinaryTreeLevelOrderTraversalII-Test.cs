using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class TreeIntv
    {
        [TestMethod]
        public void TreeIntv_LevelOrderBottomTest1()
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
            List<List<int>> res = LevelOrderBottom(root);
            Assert.AreEqual(3, res.Count);
            Assert.AreEqual(4, res[0][0]);
            Assert.AreEqual(5, res[0][1]);
            Assert.AreEqual(2, res[1][0]);
            Assert.AreEqual(3, res[1][1]);
            Assert.AreEqual(1, res[2][0]);
        }

        [TestMethod]
        public void TreeIntv_LevelOrderBottomTest2()
        {
            TreeNode root = new TreeNode(1);
            List<List<int>> res = LevelOrderBottom(root);
            Assert.AreEqual(1, res.Count);
            Assert.AreEqual(1, res[0][0]);
        }
    };
}
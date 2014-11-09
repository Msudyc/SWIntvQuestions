using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class Tree
    {
        [TestMethod]
        public void Tree_LevelOrderTest1()
        {
            TreeNode root = new TreeNode(1),
                l = new TreeNode(2),
                ll = new TreeNode(3),
                r = new TreeNode(4),
                rr = new TreeNode(5);
            root.Left = l;
            root.Right = r;
            l.Left = ll;
            r.Right = rr;
            List<List<int>> res = LevelOrder(root);
            Assert.AreEqual(3, res.Count);
            Assert.AreEqual(1, res[0][0]);
            Assert.AreEqual(2, res[1][0]);
            Assert.AreEqual(4, res[1][1]);
            Assert.AreEqual(3, res[2][0]);
            Assert.AreEqual(5, res[2][1]);
        }

        [TestMethod]
        public void Tree_LevelOrderTest2()
        {
            TreeNode root = new TreeNode(1);
            List<List<int>> res = LevelOrder(root);
            Assert.AreEqual(1, res.Count);
            Assert.AreEqual(1, res[0][0]);
        }
    };
}
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class TreeIntv
    {
        [TestMethod]
        public void TreeIntv_FlattenTest1()
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
            TreeNode res = root;
            Flatten(res);
            Assert.AreEqual(1, res.Val);
            Assert.AreEqual(2, res.Right.Val);
            Assert.AreEqual(3, res.Right.Right.Val);
            Assert.AreEqual(4, res.Right.Right.Right.Val);
            Assert.AreEqual(5, res.Right.Right.Right.Right.Val);
        }

        [TestMethod]
        public void TreeIntv_FlattenTest2()
        {
            TreeNode root = new TreeNode(1);
            TreeNode res = root;
            Flatten(res);
            Assert.AreEqual(1, res.Val);
            Assert.IsNull(res.Right);
        }
    };
}
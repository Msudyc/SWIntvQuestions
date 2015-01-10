using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class TreeIntv
    {
        [TestMethod]
        public void TreeIntv_PostorderTraversalTest1()
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
            List<int> res = PostorderTraversal(root);
            Assert.AreEqual(3, res[0]);
            Assert.AreEqual(2, res[1]);
            Assert.AreEqual(5, res[2]);
            Assert.AreEqual(4, res[3]);
            Assert.AreEqual(1, res[4]);
        }

        [TestMethod]
        public void TreeIntv_PostorderTraversalTest2()
        {
            TreeNode root = new TreeNode(1),
                l = new TreeNode(2),
                r = new TreeNode(4),
                rr = new TreeNode(5);
            root.Left = l;
            root.Right = r;
            r.Right = rr;
            List<int> res = PostorderTraversal(root);
            Assert.AreEqual(2, res[0]);
            Assert.AreEqual(5, res[1]);
            Assert.AreEqual(4, res[2]);
            Assert.AreEqual(1, res[3]);
        }

        [TestMethod]
        public void TreeIntv_PostorderTraversalTestA1()
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
            List<int> res = PostorderTraversal2(root);
            Assert.AreEqual(3, res[0]);
            Assert.AreEqual(2, res[1]);
            Assert.AreEqual(5, res[2]);
            Assert.AreEqual(4, res[3]);
            Assert.AreEqual(1, res[4]);
        }

        [TestMethod]
        public void TreeIntv_PostorderTraversalTestA2()
        {
            TreeNode root = new TreeNode(1),
                l = new TreeNode(2),
                r = new TreeNode(4),
                rr = new TreeNode(5);
            root.Left = l;
            root.Right = r;
            r.Right = rr;
            List<int> res = PostorderTraversal2(root);
            Assert.AreEqual(2, res[0]);
            Assert.AreEqual(5, res[1]);
            Assert.AreEqual(4, res[2]);
            Assert.AreEqual(1, res[3]);
        }

        [TestMethod]
        public void TreeIntv_PostorderTraversalTestB1()
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
            List<int> res = PostorderTraversal3(root);
            Assert.AreEqual(3, res[0]);
            Assert.AreEqual(2, res[1]);
            Assert.AreEqual(5, res[2]);
            Assert.AreEqual(4, res[3]);
            Assert.AreEqual(1, res[4]);
        }

        [TestMethod]
        public void TreeIntv_PostorderTraversalTestB2()
        {
            TreeNode root = new TreeNode(1),
                l = new TreeNode(2),
                r = new TreeNode(4),
                rr = new TreeNode(5);
            root.Left = l;
            root.Right = r;
            r.Right = rr;
            List<int> res = PostorderTraversal3(root);
            Assert.AreEqual(2, res[0]);
            Assert.AreEqual(5, res[1]);
            Assert.AreEqual(4, res[2]);
            Assert.AreEqual(1, res[3]);
        }
    };
}
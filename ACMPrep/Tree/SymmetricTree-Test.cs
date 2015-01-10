using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class TreeIntv
    {
        [TestMethod]
        public void TreeIntv_IsSymmetricTest1()
        {
            TreeNode root = new TreeNode(1), 
                l = new TreeNode(2), 
                ll = new TreeNode(3), 
                r = new TreeNode(2), 
                rr = new TreeNode(3);
            root.Left = l; 
            root.Right = r;
            l.Left = ll; 
            r.Right = rr;
            Assert.IsTrue(IsSymmetric(root));
        }

        [TestMethod]
        public void TreeIntv_IsSymmetricTest2()
        {
            TreeNode root = new TreeNode(1), 
                l = new TreeNode(2), 
                ll = new TreeNode(3), 
                r = new TreeNode(2), 
                rr = new TreeNode(4);
            root.Left = l; 
            root.Right = r;
            l.Left = ll; 
            r.Right = rr;
            Assert.IsFalse(IsSymmetric(root));
        }

        [TestMethod]
        public void TreeIntv_IsSymmetricTest3()
        {
            TreeNode root = new TreeNode(1), 
                l = new TreeNode(2), 
                ll = new TreeNode(3), 
                r = new TreeNode(2), 
                rr = new TreeNode(3);
            root.Left = l; 
            root.Right = r;
            l.Right = ll; 
            r.Right = rr;
            Assert.IsFalse(IsSymmetric(root));
        }

        [TestMethod]
        public void TreeIntv_IsSymmetricTest4()
        {
            TreeNode root = new TreeNode(1), 
                l = new TreeNode(2), 
                ll = new TreeNode(3), 
                r = new TreeNode(2), 
                rr = new TreeNode(3);
            root.Left = l; 
            root.Right = r;
            l.Right = ll; 
            r.Left = rr;
            Assert.IsTrue(IsSymmetric(root));
        }
    };
}
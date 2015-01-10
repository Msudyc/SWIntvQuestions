using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class TreeIntv
    {
        [TestMethod]
        public void TreeIntv_IsSameTreeTest1()
        {
            TreeNode root = new TreeNode(1), 
                r = new TreeNode(2), 
                rr = new TreeNode(3);
            root.Right = r; 
            r.Right = rr;
            TreeNode root1 = new TreeNode(1), 
                r1 = new TreeNode(2), 
                rr1 = new TreeNode(3);
            root1.Right = r1; 
            r1.Right = rr1;
            Assert.IsTrue(IsSameTree(root, root1));
        }

        [TestMethod]
        public void TreeIntv_IsSameTreeTest2()
        {
            TreeNode root = new TreeNode(1), 
                r = new TreeNode(2), 
                rr = new TreeNode(3);
            root.Right = r; 
            r.Right = rr;
            TreeNode root1 = new TreeNode(1), 
                r1 = new TreeNode(2);
            root1.Right = r1;
            Assert.IsFalse(IsSameTree(root, root1));
        }

        [TestMethod]
        public void TreeIntv_IsSameTreeTest3()
        {
            TreeNode root = new TreeNode(4), 
                r = new TreeNode(2), 
                rr = new TreeNode(3);
            root.Right = r; 
            r.Right = rr;
            TreeNode root1 = new TreeNode(1), 
                r1 = new TreeNode(2), 
                rr1 = new TreeNode(3);
            root1.Right = r1; 
            r1.Right = rr1;
            Assert.IsFalse(IsSameTree(root, root1));
        }

        [TestMethod]
        public void TreeIntv_IsSameTreeTest4()
        {
            TreeNode root = new TreeNode(1), 
                l = new TreeNode(2), 
                r = new TreeNode(3);
            root.Left = l; 
            root.Right = r;
            TreeNode root1 = new TreeNode(1), 
                l1 = new TreeNode(2), 
                r1 = new TreeNode(3);
            root1.Left = l1; root1.Right = r1;
            Assert.IsTrue(IsSameTree(root, root1));
        }
    };
}
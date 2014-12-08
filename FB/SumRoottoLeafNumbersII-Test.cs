using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACMPrep;

namespace FB
{
    public partial class FBEx
    {
        [TestMethod]
        public void FB_SumNumbersIItest1()
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
            Assert.AreEqual(281, SumNumbersII(root));
        }

        [TestMethod]
        public void FB_SumNumbersIItest2()
        {
            TreeNode root = new TreeNode(1), 
                l = new TreeNode(2), 
                r = new TreeNode(3);
            root.Left = l; 
            root.Right = r;
            Assert.AreEqual(25, SumNumbersII(root));
        }

        [TestMethod]
        public void FB_SumNumbersIItest3()
        {
            TreeNode root = new TreeNode(1);
            Assert.AreEqual(1, SumNumbersII(root));
        }
    };
}
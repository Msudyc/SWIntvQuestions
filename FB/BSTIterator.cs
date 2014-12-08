/*
Given an binary search tree, implement an iterator.
First next call will return the smallest node, second 
next call returns the second smalless node, etc. And 
if next call times is greater than bst size, return null.
*/

namespace FB
{
    #region using
    using System;
    using System.Collections.Generic;
    using System.Text;
    using ACMPrep;
    #endregion

    public class FBExBSTIterator
    {
        private Stack<TreeNode> stk;

        public FBExBSTIterator(TreeNode root)
        {
            this.stk = new Stack<TreeNode>();
            this.PrepareNext(root);
        }

        public bool HasNext()
        {
            return this.stk.Count > 0;
        }

        public TreeNode Next()
        {
            if (!this.HasNext())
                return null;

            TreeNode n = this.stk.Pop();
            this.PrepareNext(n.Right);
            return n;
        }

        private void PrepareNext(TreeNode root)
        {
            while (root != null)
            {
                this.stk.Push(root);
                root = root.Left;
            }
        }
    }
}
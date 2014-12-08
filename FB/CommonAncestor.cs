/* 
Design an algorithm and write code to find the first common ancestor of two 
nodes in a binary tree. Avoid storing additional nodes in a data structure. 
Note: this is not necessarily a binary search tree.  
 */
namespace FB
{
    #region using
    using System;
    using System.Collections.Generic;
    using ACMPrep;
    #endregion

    public partial class FBEx
    {
        public static TreeNode CommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            Tuple<bool, TreeNode> result = Helper(root, p, q);
            if (result.Item1 == true)
                return result.Item2;

            return null;
        }

        private static Tuple<bool, TreeNode> Helper(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null)
                return new Tuple<bool, TreeNode>(false, null);

            if (root == p && root == q)
                return new Tuple<bool, TreeNode>(true, root);

            Tuple<bool, TreeNode> rx = Helper(root.Left, p, q);
            if (rx.Item1 == true)
                return rx;

            Tuple<bool, TreeNode> ry = Helper(root.Right, p, q);
            if (ry.Item1 == true)
                return ry;

            if (rx.Item2 != null && ry.Item2 != null)
                return new Tuple<bool, TreeNode>(true, root);
            else if (root == p || root == q)
            {
                bool isAncestor = rx.Item2 != null || ry.Item2 != null ? true : false;
                return new Tuple<bool, TreeNode>(isAncestor, root);
            }
            else
                return new Tuple<bool, TreeNode>(
                    false, rx.Item2 != null ? rx.Item2 : ry.Item2);
        }
    }
}

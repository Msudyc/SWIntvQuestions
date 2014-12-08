/*
Print out all root to leaf paths.
*/

namespace FB
{
    #region using
    using System;
    using System.Collections.Generic;
    using System.Text;
    using ACMPrep;
    #endregion

    public partial class FBEx
    {
        public static List<string> RootToLeafPaths(TreeNode root)
        {
            List<string> result = new List<string>();
            if (root == null)
                return result;

            PrintAll(root, "", result);
            return result;
        }

        private static void PrintAll(TreeNode root, string r, List<string> result)
        {
            if (root == null)
                return;

            r += root.Val;
            if (root.Left == null && root.Right == null)
                result.Add(r);
            else
            {
                PrintAll(root.Left, r, result);
                PrintAll(root.Right, r, result);
            }
        }
    }
}
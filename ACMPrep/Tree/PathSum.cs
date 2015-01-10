/*
Given a binary tree and a sum, determine if the tree has 
a root-to-leaf path such that adding up all the values along
the path equals the given sum. 
For example:

 Given the below binary tree and sum = 22,
              5
             / \
            4   8
           /   / \
          11  13  4
         /  \      \
        7    2      1


return true, as there exist a root-to-leaf path 5.4.11.2 
which sum is 22.

class Solution {
public:
    bool hasPathSum(TreeNode *root, int sum) {
        
    }
};
*/

namespace ACMPrep
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public partial class TreeIntv
    {
        public static bool HasPathSum(TreeNode root, int sum)
        {
            if (root == null) 
                return sum == 0;

            return HasPathSum(root.Left, sum - root.Val) || 
                HasPathSum(root.Right, sum - root.Val);
        }
    }
}
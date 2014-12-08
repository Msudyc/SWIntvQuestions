/*
Given a binary tree containing digits from 0-9 only, each
root-to-leaf path could represent a number.

An example is the root-to-leaf path 1.2.3 which represents
the number 123.

Find the total sum of all root-to-leaf numbers.

For example, 
    1
   / \
  2   3

The root-to-leaf path 1.2 represents the number 12.
The root-to-leaf path 1.3 represents the number 13. 

Return the sum = 12 + 13 = 25. 

class Solution {
public:
    int sumNumbers(TreeNode *root) {
        
    }
};
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
        public static int SumNumbersII(TreeNode root)
        {
            if (root == null)
                return 0;
            int sum = 0;
            Stack<Tuple<TreeNode, int>> stk = new Stack<Tuple<TreeNode, int>>();

            stk.Push(new Tuple<TreeNode,int>(root, 0));
            while (stk.Count > 0)
            {
                Tuple<TreeNode, int> tmp = stk.Pop();
                int t = tmp.Item2 * 10 + tmp.Item1.Val;
                if (tmp.Item1.Left == null && tmp.Item1.Right == null)
                    sum += t;
                else
                {
                    if (tmp.Item1.Right != null)
                        stk.Push(new Tuple<TreeNode, int>(tmp.Item1.Right, t));
                    if (tmp.Item1.Left != null)
                        stk.Push(new Tuple<TreeNode, int>(tmp.Item1.Left, t));
                }
            }

            return sum;
        }
    }
}
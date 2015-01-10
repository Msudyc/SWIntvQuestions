/*
Given a binary tree, return the level order traversal of 
its nodes' values. (ie, from left to right, level by level).

For example:
 Given binary tree {3,9,20,#,#,15,7},

    3
   / \
  9  20
    /  \
   15   7

return its level order traversal as:

[
  [3],
  [9,20],
  [15,7]
]

*/

namespace ACMPrep
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public partial class TreeIntv
    {
        public static List<List<int>> LevelOrder(TreeNode root)
        {
            List<List<int>> result = new List<List<int>>();
            if (root == null) 
                return result;

            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);

            int count = 1, num = 0;            
            while (q.Count != 0)
            {
                List<int> tmp = new List<int>();
                num = 0;
                for (int i = 0; i < count; i++)
                {
                    root = q.Dequeue();
                    tmp.Add(root.Val);
                    if (root.Left != null)
                    {
                        q.Enqueue(root.Left);
                        num++;
                    }
                    if (root.Right != null)
                    {
                        q.Enqueue(root.Right);
                        num++;
                    }
                }

                count = num;
                result.Add(tmp);
            }

            return result;
        }
    }
}
/*
Given a collection of numbers that might contain duplicates, 
return all possible unique permutations. 

For example,
[1,1,2] have the following unique permutations:
[1,1,2], [1,2,1], and [2,1,1]. 

class Solution {
public:
    List<List<int> > permuteUnique(List<int> &num) {
        
    }
};
*/

namespace ACMPrep
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public partial class Backtracking
    {
        public static List<List<int>> PermuteUnique(List<int> num)
        {
            List<List<int>> res = new List<List<int>>();
            PermuteUniqueHelper(num, 0, res);
            return res;
        }

        private static void PermuteUniqueHelper(List<int> num, int k, List<List<int>> res)
        {
            if (k == num.Count - 1)
            {
                List<int> list = new List<int>(num);
                res.Add(list);
            }
            else
                for (int i = k; i < num.Count; i++)
                {
                    if (NoSwap(k, i, num))
                        continue;

                    Swap(num, k, i);
                    PermuteUniqueHelper(num, k + 1, res);
                    Swap(num, k, i);
                }
        }

        private static bool NoSwap(int k, int i, List<int> num)
        {
            // if swap before, no need to swap again
            for (int j = k; j < i; j++)
                if (num[j] == num[i]) 
                    return true;
            return false;
        }
    }
}
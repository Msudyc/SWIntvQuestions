/*
Follow up for "Find Minimum in Rotated Sorted Array":
 What if duplicates are allowed?

Would this affect the run-time complexity? How and why?

Suppose a sorted array is rotated at some pivot unknown to you beforehand.

(i.e., 0 1 2 4 5 6 7 might become 4 5 6 7 0 1 2).

Find the minimum element.

The array may contain duplicates.

public class Solution {
    public int findMin(int[] num) {
        
    }
}
*/

namespace ACMPrep
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public partial class BinarySearch
    {
        public static int FindMinDup(int[] num)
        {
            int L = 0, R = num.Length - 1;
            while (L < R && num[L] >= num[R])
            {
                int M = (L + R) / 2;
                if (num[M] > num[L])
                    L = M + 1;
                else if (num[M] < num[L])
                    R = M;
                else // A[L] == A[M] == A[R]
                    L = L + 1;
            }

            return num[L];
        }
    }
}
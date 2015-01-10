﻿/*
Given a sorted array and a target value, return the 
index if the target is found.

If not, return the index where it would be if it were
inserted in order.

You may assume no duplicates in the array.

Here are few examples.
[1,3,5,6], 5 → 2
[1,3,5,6], 2 → 1
[1,3,5,6], 7 → 4
[1,3,5,6], 0 → 0 

class Solution {
public:
    int searchInsert(int A[], int n, int target) {
        
    }
};
*/

namespace ACMPrep
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public partial class BinarySearch
    {
        public static int SearchInsert(int[] A, int target)
        {
            int mid, lower = 0, upper = A.Length;
            // Search for lower bound
            while (lower < upper) 
            {
                mid = (lower + upper) / 2;
                if (A[mid] < target) 
                    lower = mid + 1;
                else 
                    upper = mid;
            }

            return lower;
        }
    }
}
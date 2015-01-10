/*
Suppose a sorted array is rotated at some pivot unknown to you beforehand.

(i.e., 0 1 2 4 5 6 7 might become 4 5 6 7 0 1 2).

Find the minimum element.

You may assume no duplicate exists in the array.

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
        public static int FindMin(int[] num)
        {
            int start = 0, end = num.Length - 1;
            while (start < end && num[start] >= num[end])
            {
                int mid = (start + end) / 2;
                if (num[mid] >= num[start])
                    start = mid + 1;
                else
                    end = mid;
            }

            return num[start];
        }
    }
}
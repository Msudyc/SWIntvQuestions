/*

Binary Search

*/

namespace ACMPrep
{
    #region using
    using System;
    using System.Collections.Generic;
    using System.Text;
    #endregion

    public partial class Search
    {
        public static int BinarySearch(int[] numbers, int target)
        {
            int left = 0;
            int right = numbers.Length - 1;
            int mid;
            while (left <= right)
            {
                mid = left + (right - left) / 2;
                if (numbers[mid] == target)
                    return mid;
                else if (target < numbers[mid])
                    right = mid - 1;
                else
                    left = mid + 1;
            }

            return -1;
        }
    }
}
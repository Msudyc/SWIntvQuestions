/*

Merge Sort

*/

namespace ACMPrep
{
    #region using
    using System;
    using System.Collections.Generic;
    using System.Text;
    #endregion

    public partial class Sort
    {
        public static void MergeSort(int[] numbers)
        {
            int n = numbers.Length;
            if (n <= 1)
                return;
            int[] temp = new int[n];
            MergeSort(numbers, temp, 0, n - 1);
        }

        private static void MergeSort(int[] nums, int[] temp, int low, int high)
        {
            if (low < high)
            {
                int mid = (low + high) / 2;
                MergeSort(nums, temp, low, mid);
                MergeSort(nums, temp, mid + 1, high);
                Merge(nums, temp, low, mid, high);
            }
        }

        private static void Merge(int[] nums, int[] temp, int low, int mid, int high)
        {
            // copy both parts into the helper array
            for (int x = low; x <= high; x++)
                temp[x] = nums[x];

            int i = low;
            int j = mid + 1;
            int k = low;
            // copy smallest from either left or right side
            while (i <= mid && j <= high)
            {
                if (temp[i] < temp[j])
                    nums[k++] = temp[i++];
                else
                    nums[k++] = temp[j++];
            }

            // copy the rest
            while (i <= mid)
                nums[k++] = temp[i++];

            while (j <= high)
                nums[k++] = temp[j++];
        }
    }
}
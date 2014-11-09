/*

Heap Sort

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
        public static void HeapSort(int[] numbers)
        {
            BuildHeap(numbers);
            for (int i = numbers.Length - 1; i > 0; i--)
            {
                Swap(numbers, 0, i);
                MaxHeap(numbers, 0, i);
            }
        }

        private static void BuildHeap(int[] nums)
        {
            for (int i = nums.Length / 2; i >= 0; i--)
                MaxHeap(nums, i, nums.Length);
        }

        private static void MaxHeap(int[] nums, int i, int last)
        {
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            int largest = i;

            if (left < last && nums[left] > nums[i])
                largest = left;

            if (right < last && nums[right] > nums[largest])
                largest = right;

            if (largest != i)
            {
                Swap(nums, i, largest);
                MaxHeap(nums, largest, last);
            }
        }
    }
}
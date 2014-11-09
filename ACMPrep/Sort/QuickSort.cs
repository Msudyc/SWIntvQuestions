/*

Quick Sort

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
        public static void QuickSort(int[] numbers)
        {
            if (numbers.Length <= 1)
                return;

            QuickSort(numbers, 0, numbers.Length - 1);
        }

        private static void QuickSort(int[] numbers, int start, int end)
        {
            // at least two elements
            if (start > end - 1)
                return;

            int pivotPos = Partition(numbers, start, end);
            QuickSort(numbers, start, pivotPos - 1);
            QuickSort(numbers, pivotPos + 1, end);
        }

        private static int Partition(int[] numbers, int start, int end)
        {
            int i = start;
            int j = end;
            int pivot = numbers[i];
            while (i < j)
            {
                while (i < j && numbers[j] >= pivot)
                    j--;
                numbers[i] = numbers[j];
                while (i < j && numbers[i] <= pivot)
                    i++;
                numbers[j] = numbers[i];
            }

            numbers[i] = pivot;
            return i;
        }
    }
}
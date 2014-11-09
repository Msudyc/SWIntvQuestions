/*

Insertion Sort

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
        public static void InsertionSort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int temp = numbers[i];
                int j = i - 1;
                for (; j >= 0 && temp < numbers[j]; j--)
                    numbers[j + 1] = numbers[j];

                numbers[j + 1] = temp;
            }            
        }
    }
}
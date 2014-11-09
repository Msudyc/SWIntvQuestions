/*

Selection Sort

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
        public static void SelectionSort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int k = i;
                for (int j = i + 1; j < numbers.Length; j++)
                    if (numbers[j] < numbers[k])
                        k = j;
                if(k != i)
                    Swap(numbers, i, k);
            }            
        }
    }
}
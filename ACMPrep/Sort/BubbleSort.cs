/*

Bubble Sort

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
        public static void BubbleSort(int[] numbers)
        {            
            for (int i = 0; i < numbers.Length; i++)
            {
                bool exchange = false;
                for (int j = numbers.Length - 1; j > i; j--)
                    if (numbers[j - 1] > numbers[j])
                    {
                        Swap(numbers, j - 1, j);
                        exchange = true;
                    }

                if (!exchange)
                    return;
            }            
        }

        private static void Swap(int[] numbers, int i, int j)
        {
            int temp = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = temp;
        }
    }
}
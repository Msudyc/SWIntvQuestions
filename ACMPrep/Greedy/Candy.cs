/*
There are N children standing in a line. Each child is 
assigned a rating value. You are giving candies to these
children subjected to the following requirements: 

.Each child must have at least one candy.
.Children with a higher rating get more candies than 
 their neighbors.

What is the minimum candies you must give? 

class Solution {
public:
    int candy(List<int> &ratings) {
        
    }
};
*/

namespace ACMPrep
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public partial class Greedy
    {
        public static int Candy(int[] ratings)
        {
            int[] candyNum = new int[ratings.Length];
            int n = ratings.Length;

            for (int i = 0; i < n; i++) 
                candyNum[i] = 1;

            for (int i = 1; i < n; i++)
                if (ratings[i] > ratings[i - 1])
                    candyNum[i] = candyNum[i - 1] + 1;

            for (int i = n - 2; i >= 0; i--)
                if (ratings[i] > ratings[i + 1] && candyNum[i] <= candyNum[i + 1])
                    candyNum[i] = candyNum[i + 1] + 1;

            int result = 0;
            for (int i = 0; i < n; i++)
                result += candyNum[i];

            return result;
        }

        public static int Candy2(int[] ratings)
        {
            if (ratings.Length == 0)
                return 0;

            int[] temp = new int[ratings.Length];
            temp[0] = 1;
            int last = 0;
            for (int i = 1; i < ratings.Length; i++)
            {
                if (ratings[i] > ratings[i - 1])
                {
                    temp[i] = temp[i - 1] + 1;
                    last = i;
                }
                else
                {
                    temp[i] = 1;
                    for (int j = i - 1; j >= last && temp[j] <= temp[j + 1]; j--)
                        temp[j]++;
                }
            }

            int total = 0;
            foreach (int c in temp)
                total += c;

            return total;
        }
    }
}
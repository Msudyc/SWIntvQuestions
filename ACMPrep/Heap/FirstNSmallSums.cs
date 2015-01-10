/*
Given two lists of integers A, B with length N. Pick a number a from A and pick a
number b from B you will get a sum = a + b. There are N*N sums in total. Make function to 
return the first N smallest sums. N is a very big number and you cannot calculate all N*N sums
and sort them to get the first N.

*/

namespace ACMPrep
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public partial class HeapIntv
    {
        public static List<int> GetFirstNSmallSums(List<int> A, List<int> B)
        {
            List<int> result = new List<int>();
            int n = A.Count;
            if (n == 0)
                return result;
            // heap
            Heap<Tuple<int, int, int>> heap = 
                new Heap<Tuple<int, int, int>>(new Comparer());

            A.Sort();
            B.Sort();
            for (int i = 0; i < n; i++)
            {
                Tuple<int, int, int> t = new Tuple<int, int, int>(
                    A[i] + B[0], i, 0);
                heap.Insert(t);
            }

            for (int i = 0; i < n; i++)
            {
                Tuple<int, int, int> t = heap.Delete();
                result.Add(t.Item1);
                Tuple<int, int, int> k = new Tuple<int, int, int>(
                    A[t.Item2] + B[t.Item3 + 1], t.Item2, t.Item3 + 1);
                heap.Insert(k);
            }

            return result;
        }

        public class Comparer : IComparer<Tuple<int, int, int>>
        {
            public int Compare(Tuple<int, int, int> x, Tuple<int, int, int> y)
            {
                return x.Item1 - y.Item1;
            }
        }
    }
}
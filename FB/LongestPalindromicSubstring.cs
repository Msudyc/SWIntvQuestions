/*
Given a string S, find the longest palindromic substring in S. 
You may assume that the maximum length of S is 1000, and there 
exists one unique longest palindromic substring.

class Solution {
public:
    string longestPalindrome(string s) {
        
    }
};
*/

namespace FB
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public partial class FBEx
    {
        public static string LongestPalindrome(string s)
        {
            /* DP
            Define P[ i, j ] ← true if the substring Si ... Sj is a palindrome, otherwise false.
            P[ i, j ] ← ( P[ i+1, j-1 ] and Si = Sj )
            The base cases are:
                P[ i, i ] ← true
                P[ i, i+1 ] ← ( Si = Si+1 )
            */
            int n = s.Length, longestBegin = 0, maxLen = 1;
            bool[,] table = new bool[1000, 1000];
            for (int i = 0; i < n; i++) 
                table[i,i] = true;

            for (int i = 0; i < n-1; i++)
                if (s[i] == s[i+1])
                {
                    table[i,i+1] = true;
                    longestBegin = i;
                    maxLen = 2;
                }

            for (int len = 3; len <= n; len++) 
                for (int i = 0; i < n-len+1; i++)
                {
                    int j = i+len-1;
                    if (s[i] == s[j] && table[i+1,j-1]) 
                    {
                        table[i,j] = true;
                        longestBegin = i;
                        maxLen = len;
                    }
                }

            return s.Substring(longestBegin, maxLen);
        }
    }
}
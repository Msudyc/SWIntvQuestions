﻿/*
'?' Matches any single character.
'*' Matches any sequence of characters (including 
    the empty sequence).

The matching should cover the entire input string 
 (not partial).

The function prototype should be:
bool isMatch(const char *s, const char *p)

Some examples:
isMatch("aa","a") → false
isMatch("aa","aa") → true
isMatch("aaa","aa") → false
isMatch("aa", "*") → true
isMatch("aa", "a*") → true
isMatch("ab", "?*") → true
isMatch("aab", "c*a*b") → false

class Solution {
public:
    bool isMatch(const char *s, const char *p) {
        
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
        public static bool IsWildMatch(string s, string p)
        {
            if (s == null || p == null)
                return false;

            if (s == p)
                return true;

            int pS = 0;
            int pP = 0;

            int pStar = -1;
            int pSBackTrack = -1;

            while (pS < s.Length)
            {
                if (pP < p.Length && (s[pS] == p[pP] || p[pP] == '?'))
                {
                    ++pS;
                    ++pP;
                }
                else if(pP < p.Length && p[pP] == '*')
                {
                    pStar = pP;
                    pSBackTrack = pS;
                    ++pP;
                }
                else if(pStar != -1)
                {
                    pS = pSBackTrack;
                    pP = pStar + 1;
                    ++pSBackTrack;
                }
                else
                    return false;
            }

            while(pP < p.Length && p[pP] == '*')
                ++pP;

            return pS == s.Length && pP == p.Length;
        }

        public static bool IsWildMatchR(string s, string p)
        {
            if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(p))
                return string.IsNullOrEmpty(p) && string.IsNullOrEmpty(s);

            char fs = s[0];
            char fp = p[0];

            if (fp != '*')
                return (fs == fp || fp == '?') && IsWildMatchR(s.Substring(1), p.Substring(1));
            else
            {
                for (int i = 0; i <= s.Length; i++)
                    if (IsWildMatchR(s.Substring(i), p.Substring(1)))
                        return true;

                return false;
            }
        }

        public static bool IsWildMatchDP(string s, string p)
        {
            if (string.IsNullOrEmpty(s))
                return string.IsNullOrEmpty(p);

            int m = p.Length;
            int n = s.Length;

            bool[,] dp = new bool[m + 1, n + 1];
            dp[0, 0] = true;
            for (int i = 1; i <= n; i++)
                dp[0, i] = false;
            for (int i = 1; i <= m; i++)
            {
                if (p[i - 1] == '*')
                    dp[i, 0] = dp[i - 1, 0];
                else
                    dp[i, 0] = false;
            }

            for (int i = 1; i <= m; i++)
                for (int j = 1; j <= n; j++)
                {
                    if (p[i - 1] == '*')
                    {
                        for (int k = 0; k < j; k++)
                        {
                            if (dp[i - 1, k] == true)
                            {
                                dp[i, j] = true;
                                break;
                            }
                        }
                    }
                    else
                    {
                        if (p[i - 1] == '?' || p[i - 1] == s[j - 1])
                            dp[i, j] = dp[i - 1, j - 1];
                    }
                }

            return dp[m, n];
        }
    }
}
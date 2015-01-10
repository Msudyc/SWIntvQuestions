/*
Given n pairs of parentheses, write a function to generate 
all combinations of well-formed parentheses. 

For example, given n = 3, a solution set is: 

"((()))", "(()())", "(())()", "()(())", "()()()" 

class Solution {
public:
    List<string> generateParenthesis(int n) {
        
    }
};
*/

namespace ACMPrep
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public partial class Backtracking
    {
        public static List<string> GenerateParenthesis(int n)
        {
            List<string> result = new List<string>();
            Generate(n, n, "", result);
            return result;
        }

        private static void Generate(int l, int r, string s, List<string> res)
        {
            if (l == 0 && r == 0)
                res.Add(s);
            else
            {
                if (l > 0)
                    Generate(l - 1, r, s + "(", res);

                if (r > l)
                    Generate(l, r - 1, s + ")", res);
            }
        }
    }
}
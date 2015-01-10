/*
Validate if a given string is numeric.

Some examples:
"0" => true
" 0.1 " => true
"abc" => false
"1 a" => false
"2e10" => true

Note: It is intended for the problem statement to be 
ambiguous. You should gather all requirements up front 
before implementing one. 

class Solution {
public:
    bool isNumber(const char *s) {
        
    }
};
*/

namespace ACMPrep
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public partial class StringIntv
    {
        public static bool IsNumber(string s)
        {
            int[,] mat = {{0 ,0 ,0 ,0 ,0 ,0 ,0}, // false
                          {0 ,2 ,3 ,0 ,1 ,4 ,0}, // 1
                          {0 ,2 ,5 ,6 ,9 ,0 ,10},// 2
                          {0 ,5 ,0 ,0 ,0 ,0 ,0}, // 3
                          {0 ,2 ,3 ,0 ,0 ,0 ,0}, // 4
                          {0 ,5 ,0 ,6 ,9 ,0 ,10},// 5
                          {0 ,7 ,0 ,0 ,0 ,8 ,0}, // 6
                          {0 ,7 ,0 ,0 ,9 ,0 ,10},// 7
                          {0 ,7 ,0 ,0 ,0 ,0 ,0}, // 8
                          {0 ,0 ,0 ,0 ,9 ,0 ,10},// 9
                          {10,10,10,10,10,10,10} // 10
                         };
            int i = 0, stat = 1;
            while(i < s.Length) 
            {
                int type = 0;
                if(s[i] >= '0' && s[i] <= '9') 
                    type = 1;
                else if(s[i] == '.') 
                    type = 2; 
                else if(s[i] == 'e') 
                    type = 3; 
                else if(s[i] == ' ') 
                    type = 4;
                else if(s[i] == '+' || s[i] == '-') 
                    type = 5;            
                stat = mat[stat, type];
                if(stat == 0) 
                    return false;
                i++;
            }
        
            stat = mat[stat, 6];
            if(stat == 10) 
                return true;
            else 
                return false;
        }

        public static bool IsNumber2(string s)
        {
            int i = 0, n = s.Length;

            // leading white spaces
            while(i < n && char.IsWhiteSpace(s[i]))
                i++;

            // plus minus sign
            if (i < n && (s[i] == '+' || s[i] == '-'))
                i++;

            // numbers
            bool isNumeric = false;
            while (i < n && char.IsDigit(s[i]))
            {
                i++;
                isNumeric = true;
            }

            // decimal
            if (i < n && s[i] == '.')
            {
                i++;
                // fractionap part
                while (i < n && char.IsDigit(s[i]))
                {
                    i++;
                    isNumeric = true;
                }
            }

            // exponent part
            if (isNumeric && i < n && s[i] == 'e')
            {
                i++;
                isNumeric = false;
                if (i < n && (s[i] == '+' || s[i] == '-')) 
                    i++;
                while (i < n && char.IsDigit(s[i]))
                {
                    i++;
                    isNumeric = true;
                }
            }

            // trailing white spaces
            while (i < n && char.IsWhiteSpace(s[i])) 
                i++;

            return isNumeric && i == n;
        }
    }
}
/*
Determine whether an integer is a palindrome. Do this without 
extra space.

class Solution {
public:
    bool isPalindrome(int x) {
        
    }
};
*/

namespace ACMPrep
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public partial class MathIntv
    {
        public static bool IsPalindrome(int x)
        {
            if(x < 0) 
                return false;
            else if (x < 10) 
                return true;
            else
            {
                while (x >= 10)
                {
                    int r = x % 10;
                    int t = x;
                    int l = 1;
                    while (t >= 10) 
                    { 
                        t /= 10; 
                        l *= 10; 
                    }
                    if (t != r) 
                        return false;

                    if ((x % l) >= l / 10)
                        x = (x % l - r) / 10;
                    else
                        x = (x % l + l / 10 - r) / 10 + 1;
                }

                return true;
            }
        }
    }
}
/*
Implement pow(x, n). 

class Solution {
public:
    double pow(double x, int n) {
        
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
        public static double Pow(double x, int n)
        {
            if (n == 0) 
                return 1.0;

            double half = Pow(x, n / 2);
            if (n % 2 == 0) 
                return half * half;
            else if (n > 0) 
                return half * half * x;
            else 
                return half * half / x;
        }
    }
}
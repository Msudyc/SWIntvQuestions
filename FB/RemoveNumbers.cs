/*
Given a sequence of distinct integers, your program must remove as few 
elements as possible in order for the elements which are not removed to 
appear in ascending order.  If there is more than one way to do this, your 
program must print the number of all solutions.

 Example.

 Given   1 2 3 8 10 5 6 7 12 9 11 4 0 
 Remove        8 10       12      4 0 
 Remain  1 2 3      5 6 7    9 11       (ascending)

To form an ascending sequence, you must remove at least 5 elements. 
There is only one way to do it.
*/

namespace FB
{
    #region using
    using System;
    using System.Collections.Generic;
    using System.Text;
    #endregion

    public partial class FBEx
    {
        public static int RemoveNumbers(int param)
        {
            return param;
        }
    }
}
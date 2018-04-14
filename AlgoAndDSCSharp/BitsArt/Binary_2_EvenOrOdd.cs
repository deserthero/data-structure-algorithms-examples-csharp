using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoAndDSCSharp.BitsArt
{
    public class Binary_2_EvenOrOdd
    {

        #region Solution Description
        #endregion

        #region Some notes
        //I don't think it's fair to say it's faster than using division or modulus.
        //The C standard doesn't say anything about performance of operators,
        //and any decent compiler will produce fast code for either.
        //I would personally choose the idiom that communicates my intent,
        //and % seems more appropriate here

        //For ANSI standard C and early Java,
        //depends on the computer system. It's unspecified what representation is used for signed numbers -- 2's compliment,
        //1's compliment, grey-coded, etc. But modulus is always modulus.

        // It doesn't work with negative numbers:
        // The C standard stipulates that negative numbers can be represented in 3 ways:

        //2's complement
        //1's complement
        //sign and magnitude
        //Checking like this:

        //isEven = (x & 1);
        //will work for 2's complement and sign and magnitude representation, but not for 1's complement.

        //However, I believe that the following will work for all cases:

        //isEven = (x & 1) ^ ((-1 & 1) | ((x < 0) ? 0 : 1)));
        #endregion

        public bool IsEven(int number)
        {
            if ((number & 1) == 0) return true;
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoAndDSCSharp.Algorithms.Coursera.AlgorithmicToolbox
{
    public class Assignment_2_2_GreatestCommonDivisor
    {

        #region Greatest Common Divisor

        #region Naive Algorithm
        public static int GreatestCommonDivisor(int a, int b)
        {
            var n = a < b ? a : b;
            var result = -1;

            for (int i = 0; i < n; i++)
            {
                if(a % n == 0 && b % n == 0)
                {
                    result = n;
                    break;
                }
            }

            return result;
        }
        #endregion

        #endregion
    }
}

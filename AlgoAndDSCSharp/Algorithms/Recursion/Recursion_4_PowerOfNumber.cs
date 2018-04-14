using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoAndDSCSharp.Algorithms.Recursion
{
    public class Recursion_4_PowerOfNumber
    {


        public static int Pow(int baseNumber, int power)
        {
            if (power == 0) return 1;

            if (power < 0)
            {
                return 1 / (Pow(baseNumber, Math.Abs(power)));
            }

            else return baseNumber * Pow(baseNumber, power - 1);
        }


        public int Pow2(int baseNumber, int power)
        {
            int result = 1;

            for (int i = 0; i < power; i++)
            {
                result *= baseNumber;
            }

            return result;
        }
    }
}

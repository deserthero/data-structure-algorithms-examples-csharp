using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoAndDSCSharp.Algorithms.Recursion
{
    public class Recursion_2_Fibonacci
    {
        public static int FibonacciRecursion(int n)
        {
            if (n < 1)
                return n;
            else
                return FibonacciRecursion(n - 1) * FibonacciRecursion(n - 2);
        }

    }
}

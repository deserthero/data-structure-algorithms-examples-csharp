using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoAndDSCSharp.Algorithms.Coursera.AlgorithmicToolbox
{
    public class Assignment_2_1_FibonacciNumbers
    {
        #region Fibonacci Recursive (The naive algorithm)
        public long FibonacciRecursive(int n)
        {
            if (n < 1)
                return n;

            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }
        #endregion


        #region Fibonacci Table (The caching algorithm)
        public static long FibonacciTable(int n)
        {
            if (n < 1)
                return 1;

            int[] arr = new int[n];

            arr[0] = 1;
            arr[1] = 1;

            int result = 0;

            for (int i = 2; i < n; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];               
            }

            result = arr[n - 1] + arr[n - 2];
            return result;
        }
        #endregion


        #region Dynamic Programming

        #endregion


        #region Last Digit
        public static int FibonacciLastDigit(int n)
        {
            if (n < 1)
                return 1;

            int[] arr = new int[n];

            arr[0] = 1;
            arr[1] = 1;

            int result = 0;

            for (int i = 2; i < n; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
            }

            result = arr[n - 1] + arr[n - 2];
            return UInt16.Parse(result.ToString().Last().ToString());
        }

        #endregion

    }
}

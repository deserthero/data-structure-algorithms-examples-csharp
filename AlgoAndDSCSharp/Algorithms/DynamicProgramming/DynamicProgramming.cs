using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoAndDSCSharp.Algorithms.DynamicProgramming
{
    public class DynamicProgramming
    {
        #region Intro

        // - Dynamic programming is a technique that we can use it in our algorithms but it's not algorithm.
        // - Dynamic programming technique is a very important one.

        // - There is a very important observation that let us directly use DP, which is when our problem can be solved
        //   recursively and it's subproblems overlaps, hence calling sub-problems more than one and repeating it's calculation again and again
        //   makes the order exponentials for example: 2^n even we have a small space which should not made all this performance hits.

        // - There is a very important thing to take into account. We use space to save time, so for the problems with a very high n may not fit in dynamic programming.
        // - When the original space is small enough to be memorized, then saving these sub problems makes order small to as each sub problem is calculated once.

        // - There are 2 ways to solve any problem. You can solve it using top-down approch which called Memoization
        //   or using bottom-up one which called Tabulation.

        // Fibonacci Example:
        //      int fib(int n)
        //      {
        //          if (n < 1)
        //              return 1;

        //          return fib(n - 1) + fib(n - 2);
        //      }
        // Search Space when n = 5:
        //                                                            f(5)
        //                                                     f(4)          f(3)
        //                                                 f(3)   f(2)    f(2)   f(1)
        //                                              f(2)f(1) f(1)f(0) f(1)f(0)
        //
        // So, It's a tree of leafs and the last leaf is f(0) or f(1) and that's the base case for the recursion.
        // So the runtime for this recursion is exponential (about 1.6^n) and that's too much and that's due to the overlapping between sub-problems calls as we see in the
        // Search graph: So this problem is a very good one to apply DI on and by that we will enhance the performance too much as we will return to the space (n for example) order cause we caching all
        // the overlapping calls.

        // So dynamic programming allow us to access our space with a space runtime for example linear instead of exponential one due to the overlapping in subproblems calling.

        // General Rules to solve a problem using DI technique:
        // Recursion function && Sub-calls overlap && Small search space, so putting in memory is Doubable.
        // 
        // Examples to apply DI: Recursion.
        // Examples not to apply DI: Merge sort (cause it's Divide and conqure problem with no overlapping between sub calls).
        //
        // DI most typicall categories:  Minimization problems, Maximization problems, and counting and sometime it has adhoc usages. 
        // DI most typically scenarios: think about the problem and if it's can solve recursively with an overlapping and small search space so use DI.

        // DI types:
        // There are 2.
        // Top-Down which called Memoization: Here we cache values from top to down step by step with our recursion calls.
        // Bottom-Up which called Tabulation and some people refer to it directly as DI: Here we build our caching using iteration or recursion from bottom-up then we used our cached values.

        // Example on Top-down fibonacci:

        //int fibTopDown(int n, int arr[])
        //{
        //    if (n <= 1)
        //        return 1;
        //    if (arr[n] != 0)
        //        return arr[n];
        //    return arr[n] = fibTopDown(n - 1, arr) + fibTopDown(n - 2, arr);
        //}

        //int fibTopDownContext(int n)
        //{
        //    int arr[6] = { 0 };
        //    return fibTopDown(n, arr);
        //}

        // Example on bottom-up fibonacci:

        //    int fibBottomUp(int n)
        //    {
        //        int arr[n] = { };
        //        arr[0] = arr[1] = 1; // base case
        //        for (int i = 2; i <= n; i++)
        //        {
        //            arr[n] = fibBottomUp(n - 1) + fibBottomUp(n - 2);
        //        }
        //        return arr[n];
        //    }
        // Note: Typically: Memoization is more natural but in some cases Tabulation is the must.
        #endregion

        #region Cracking The Coding Interview

        #endregion


        #region Coursera

        #endregion


        #region Arabic Competitive Programming 

        #region Find array max. paths by move right and down only.
        // Given grid of postive numbers, start from 0,0 and end at n,n. Move only to right and down
        // Find path with sum of numbers is maximum.

        // 5 1 2
        // 6 7 8
        // 1 4 9

        // Paths: 51289, 51789, 51749, 56789,56749, 56149
        // Paths: 5 { 1 {28}, 78, 74}, 6 {78, 74, 14}} 9
        // We have 2 chooses * n =  2 * 3 = 6

        // This attempt is of course wrong as it's
        // not work good with recursion, i passed the array
        /// but i want to pass the x,y and ensure we find a
        /// base case which x and y is at end.
        //public void GetMaxPath(int[] arr)
        //{
        //    int max = 0;
        //    int start = arr[0];
        //    int end = arr[arr.Length - 1];
        //    ...
        //}

        // Recursion 
        //public int GetMaxPath(int r, int c, int[][] arr)
        //{
        //    // Base Case
        //    if (r == arr.GetLength(0) - 1 & c == arr.GetLength(1) - 1)
        //    {
        //        return arr[r][c];
        //    }
        //    int firstPath = GetMaxPath(r, c + 1, arr);
        //    int secondPath = GetMaxPath(r + 1, c, arr);
        //    return arr[r][c] + Math.Max(firstPath, secondPath);
        //}

        public int GetMaxPathTopDownContext(int r, int c, int[,] arr)
        {
            int[,] mem = new int[arr.GetLength(0), arr.GetLength(1)];

            for (int i = 0; i < mem.GetLength(0); i++)
            {
                for (int j = 0; j < mem.GetLength(1); j++)
                {
                    mem[i, j] = -1;
                }
            }

            return GetMaxPathTopDown(r, c, arr, mem);
        }

        public int GetMaxPathTopDown(int r, int c, int[,] arr, int[,] mem)
        {
            if (r >= arr.GetLength(0) || c >= arr.GetLength(1))
            {
                return 0;
            }

            // Base Case
            if (r == arr.GetLength(0) - 1 && c == arr.GetLength(1) - 1)
            {
                return arr[r, c];
            }

            if (mem[r, c] != -1)
            {
                return mem[r, c];
            }

            int firstPath = GetMaxPathTopDown(r, c + 1, arr, mem);
            int secondPath = GetMaxPathTopDown(r + 1, c, arr, mem);
            return mem[r, c] = arr[r, c] + Math.Max(firstPath, secondPath);
        }

        public int GetMaxPathBottomUp(int r, int c, int[,] arr)
        {
            // Base case is getting to end which is arr(n-1, n-1)
            // Initial case will be storring first route or second route to arr(0,0) so arr(0,0) += max(arr(1,0), arr(0,1)) and then start from the max one .. check hassan code


            var maxPath = new int[2 * arr.Rank]; // We have only 2 options * dimension of the array
            maxPath[0] = arr[0, 0];
            maxPath[3] = arr[arr.GetLength(0) - 1, arr.GetLength(1) - 1];


            for (int i = 0; i < arr.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < arr.GetLength(1) - 1; j++)
                {
                    if (i == arr.GetLength(0) - 1 && j == arr.GetLength(1) - 1)
                        break;

                    maxPath[i + 1] += Math.Max(arr[i, j + 1], arr[i + 1, j]);
                }
            }


            //1, 2, 3 
            //3, 4, 5 
            //6, 7, 8

            return maxPath.Sum();
        }

        #endregion

        #endregion

        #region HackerRank

        #endregion


        #region Geeks For Geeks

        #endregion
    }
}

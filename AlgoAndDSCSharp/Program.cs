using AlgoAndDSCSharp.Algorithms.Coursera.AlgorithmicToolbox;
using AlgoAndDSCSharp.Algorithms.DynamicProgramming;
using AlgoAndDSCSharp.Algorithms.Recursion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoAndDSCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Algorithms

            //1- Assignment-1-1-SumTwoNumbers
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine(Assignment_1_1_SumTwoNumbers.SumTwoNumbers(a, b));
            //Console.ReadLine();

            // 2- Assignment_1_2_MaximumPairwiseProduct
            //int[] seq1 = { 7, 5, 14, 2, 8, 8, 10, 1, 2, 3 };
            //int[] seq2 = { 100000, 90000 };       
            //var maxProduct = Assignment_1_2_MaximumPairwiseProduct.MaxPairwiseProductFast(seq2);
            //Console.WriteLine(maxProduct);
            //Console.ReadLine();

            // 2- Assignment_1_2_MaximumPairwiseProduct_StressTest
            //Assignment_1_2_MaximumPairwiseProduct_StressTest.StressTest(Assignment_1_2_MaximumPairwiseProduct_StressTest.MaxPairwiseProduct, Assignment_1_2_MaximumPairwiseProduct.MaxPairwiseProductFast);

            // 3- Assignment_1_3_CoinChangeProblem_SmallestPossibleNumberOfCoins
            //int[] coins = { 9, 6, 5, 1 };
            //int v = 11;
            //var x = Assignment_1_3_CoinChangeProblem_SmallestPossibleNumberOfCoins.MinCoins(v, coins);
            //Console.WriteLine();


            #endregion

            #region Recursion
            //  Console.WriteLine(Recursion_3_PalindromeString.IsStringPalindrome2("rotodr"));
            //Console.WriteLine(Recursion_4_PowerOfNumber.Pow(5,2));
            //Console.ReadLine();
            #endregion

            #region DI
            DynamicProgramming di = new DynamicProgramming();
            //var max = di.GetMaxPathTopDownContext(0, 0, new int[3, 3] { { 1, 2, 3 }, { 3, 4, 5 }, { 6, 7, 8 } });
            var max2 = di.GetMaxPathBottomUp(0, 0, new int[3, 3] { { 1, 2, 3 }, { 3, 4, 5 }, { 6, 7, 8 } });
            #endregion

        }
    }
}

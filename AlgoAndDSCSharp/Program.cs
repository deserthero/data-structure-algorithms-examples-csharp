using AlgoAndDSCSharp.Algorithms.Coursera.AlgorithmicToolbox;
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
            int[] seq1 = { 7, 5, 14, 2, 8, 8, 10, 1, 2, 3 };
            int[] seq2 = { 100000, 90000 };       
            var maxProduct = Assignment_1_2_MaximumPairwiseProduct.MaxPairwiseProductFast(seq2);
            Console.WriteLine(maxProduct);
            Console.ReadLine();
            #endregion

        }
    }
}

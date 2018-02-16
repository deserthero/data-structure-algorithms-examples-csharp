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

            //1- Assignment -1-1-SumTwoNumbers
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(Assignment_1_1_SumTwoNumbers.SumTwoNumbers(a, b));
            Console.ReadLine();
            #endregion

        }
    }
}

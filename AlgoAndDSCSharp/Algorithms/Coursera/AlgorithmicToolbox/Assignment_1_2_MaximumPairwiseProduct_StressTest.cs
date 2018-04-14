using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoAndDSCSharp.Algorithms.Coursera.AlgorithmicToolbox
{
    public class Assignment_1_2_MaximumPairwiseProduct_StressTest
    {
        // The other alternative, trivial and slow, but correct implementation of an algorithm 

        public static long MaxPairwiseProduct(int[] sequence)
        {
            long result = -1;

            for (int i = 0; i < sequence.Length; ++i)
            {
                for (int j = i; j < sequence.Length; ++j)
                {
                    if ((long)sequence[i] * sequence[j] > result)
                    {
                        result = (long)sequence[i] * sequence[j];
                    }
                }
            }

            return result;
        }

        // Stress Test
        public static void StressTest(Func<int[], long> firstMethod, Func<int[], long> secondMethod)
        {
            while (true)
            {
                int n = new Random().Next() % 10 + 2; // As the problem specified that min. should be 2 we add 2 to the random number between 0 and 9 - in .NET we can do it like: int n = new Random()Next(2,11);
                int[] a = new int[n];

                for (int i = 0; i < n; i++)
                {
                    a[i] = new Random().Next() % 100000;
                }

                long res1 = firstMethod(a);
                long res2 = secondMethod(a);

                if (res1 != res2)
                {
                    Console.WriteLine("Wrong Answer: {0} {1}", res1, res2);
                    break;
                }
                else
                {
                    Console.WriteLine("OK");
                }
            }
        }

    }
}

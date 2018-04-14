using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoAndDSCSharp.Algorithms.Coursera.AlgorithmicToolbox
{
    public class Assignment_1_3_CoinChangeProblem_SmallestPossibleNumberOfCoins
    {
        #region Change Problem Description
        // Convert some amount of money into given denominations, using the smallest possible number of coins.
        // Input: An integer money and an array of d denominations c = (c1, c2,..., cd), in decreasing order of value(c1 > c2 >···> cd).
        // Output: A list of d integers i1, i2,...,id such that c1·i1 + c2·i2 + ···+ cd·id = money, and i1 +i2 +···+ id is as small as possible.
        //Examples:
        // Input: coins[] = {25, 10, 5}, V = 30
        // Output: Minimum 2 coins required
        // We can use one coin of 25 cents and one of 5 cents
        // Input: coins[] = {9, 6, 5, 1}, V = 11
        // Output: Minimum 2 coins required
        // We can use one coin of 6 cents and 1 coin of 5 cents


        // This problem is a variation of another well known problem called Coin Change Problem. Here instead of finding total number of possible solutions, we need to find the solution with minimum number of coins.
        // The minimum number of coins for a value V can be computed using below recursive formula.

        // If V == 0, then 0 coins required.
        // If V > 0
        // minCoin(coins[0..m - 1], V) = min {1 + minCoins(V-coin[i])}
        // where i varies from 0 to m-1 
        // and coin[i] <= V
        #endregion

        #region C#
        public static int MinCoins(int money, int[] denominations)
        {
            if (money == 0)
                return 0;

            BubbleSort(denominations);
            RvereseArray(denominations,0, denominations.Length - 1);

            int minCoins = 0;

            for (int i = 0; i < denominations.Length; i++)
            {
                while (money >= denominations[i])
                {
                    money = money - denominations[i];
                    minCoins += 1;
                }
            }

            return minCoins;

        }

        #endregion

        #region C# Helpers
        static void Swap(ref int xp, ref int yp)
        {
            int temp = xp;
            xp = yp;
            yp = temp;
        }

        static void BubbleSort(int[] arr)
        {
            int i, j;
            for (i = 0; i < arr.Length - 1; i++)

                // Last i elements are already in place   
                for (j = 0; j < arr.Length - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                        Swap(ref arr[j], ref arr[j + 1]);
        }

        static void RvereseArray(int[] arr, int start, int end)
        {
            int temp;
            if (start >= end)
                return;
            temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
            RvereseArray(arr, start + 1, end - 1);
        }

        #endregion
    }
}

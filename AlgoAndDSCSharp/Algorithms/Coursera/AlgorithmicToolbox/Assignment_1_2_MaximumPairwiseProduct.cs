using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoAndDSCSharp.Algorithms.Coursera.AlgorithmicToolbox
{
    public class Assignment_1_2_MaximumPairwiseProduct
    {
        // TODO: Finalize theoritical part and stuff about strees test and test cases.
        #region MaximumPairwiseProduct Description
        // MaximumPairwiseProductProblem Find the maximum product of two distinct numbers in a sequence of non-negative integers. 
        // Input: Asequence of non-negative integers.
        // Output: The maximum value that can be obtained by multiplying two diﬀerent elements from the sequence.
        // Inputformat: The ﬁrst line contains an integer n. The next line contains n non-negative integers a1,...,an (separated by spaces). .
        // Outputformat: The maximum pairwise product.
        // Constraints: 2≤ n ≤ 2·105; 0 ≤ a1,...,an≤2·105.
        // Note that i and j should be diﬀerent, though it may be the case that ai =aj.  
        // Sample Input:
        // 3
        // 1 2 3
        // Sample Output:
        // 6
        // Timelimits(sec.): C 1 C++ 1 Java 1.5 Python 5 C# 1.5 Haskell 2 JavaScript 5 Ruby 5 Rust 1 Scala 3
        // Memorylimit. 512 Mb.
        #endregion

        #region Some Important things to note
        // 1
        // In the Naive Algorithm which uses O(n^2) algortim this Will introduce time limit exceeded  with some cases
        // because of MaxPairwiseProductNaive performs of the order of n^2 steps on a sequence of length n.
        // For the maximal possible value n = 2·10^5, the number of steps is of the order 4·10^10.
        // Since many modern computers perform roughly 10^8–10^9 basic operations per second (this depends on a machine, of course),
        // it may take tens of seconds to execute MaxPairwiseProductNaive, exceeding the time limit for the Maximum Pairwise Product Problem.
        // We need a faster algorithm!

        // 2
        // The faster algorithm is very easy, we should find the first and second biggest no. and multiply them.
        // This will give us O(n) time complexity.

        // 3
        // 
        #endregion

        #region Naive Algorithm (Will introduce  time limit exceeded  with some cases)
        //A naive way to solve the Maximum Pairwise Product Problem is to go through all possible pairs of the input elements A[1...n] = [a1,..., an]
        //and to ﬁnd a pair of distinct elements with the largest product:

        // Pseudocode 
        //MaxPairwiseProductNaive(A[1...n]):
        //product←0 
        //for i from 1 to n:
        // for j from 1 to n:
        //  if i != j:
        //   if product<A[i]·A[j]:
        //    product←A[i]·A[j]
        //return product

        // Optimized Pseudocode
        //MaxPairwiseProductNaive(A[1...n]):
        //product←0 
        //for i from 1 to n:
        // for j from i + 1 to n:
        //    product←max(product,A[i]·A[j])
        //return product

        // C++
        // #include <iostream>
        // #include <vector>
        // using std::vector;
        // using std::cin;
        // using std::cout;
        // using std::max;
        // int MaxPairwiseProduct(const vector<int>& numbers) {
        // int product = 0;
        // int n = numbers.size();
        // for (int i = 0; i < n; ++i) 
        // { 
        // for (int j = i + 1; j < n; ++j)
        // { 
        // product = max(product, numbers[i] * numbers[j]);
        // } 
        // } 
        // return product;
        // }
        //    int main()
        //    {
        //        int n;
        //        cin >> n;
        //        vector<int> numbers(n);
        //        for (int i = 0; i < n; ++i){
        //         cin >> numbers[i]; 
        //        }
        //        int product = MaxPairwiseProduct(numbers);
        //        cout << product << "\n";
        //        return 0;
        //    }

        // Python
        // # Uses python3
        // n = int(input())
        // a = [int(x) for x in input().split()]
        // product = 0
        // for i in range(n):
        //  for j in range(i + 1, n):
        //   product = max(product, a[i] * a[j])
        //print(product)Python

        #endregion

        #region Faster Algorithm

        #region Pesudocode
        //MaxPairwiseProductFast(A[1...n]):
        //index1←1
        //for i from 2 to n:
        //  if A[i]> A[index1]:
        //    index1←i
        //if index1 =1:
        //  index2←2
        //else:
        //  index2←1
        //for i from 1 to n:
        //  if A[i]!= A[index1] and A[i]> A[index2]:
        //    index2←i
        //return A[index1]·A[index2]
        #endregion

        #region C#

        public static long MaxPairwiseProductFast(int[] sequence)
        {
            if (sequence.Length == 1)
                throw new Exception("No Pairs to product");

            int firstMax = 0;
            int secondMax = 0;

            for (int i = 0; i < sequence.Length; i++)
            {
                // Here, we handle the past as we assign the past largest value
                // to secondMax if we found largest than it and then assign the
                // current largest one to the firstMax
                if (sequence[i] > firstMax)
                {
                    secondMax = firstMax;
                    firstMax = sequence[i];
                }
                // Here, we handle the future as if the number is lower than
                // the firstMax but is the second largest one we assign it here to
                // the secondMax
                else if (sequence[i] > secondMax)
                    secondMax = sequence[i];
            }


            return (long)firstMax * secondMax;
        }

        #endregion

        #region C++
        //#include <iostream>
        //#include <vector>
        //#include <stdexcept>
        //using namespace std;
        //int64_t MaxPairwiseProductFast(const vector<int>& seq)
        //    {
        //      if(seq.size() == 1)
        //      {
        //         throw std::logic_error( "No Pairs to product" );
        //      }
        //        int firstMax = 0;
        //        int secondMax = 0;

        //        for (int i = 0; i < seq.size(); i++)
        //        {
        //            if (seq[i] > firstMax)
        //            {
        //                secondMax = firstMax;
        //                firstMax = seq[i];
        //            }
        //            else if (seq[i] > secondMax)
        //            {
        //                secondMax = seq[i];
        //            }
        //        }

        // // Cast here is very important because the product of two int32 will overflow so we need to cast any of them to ensure that the result will be put inside int64
        //  return (int64_t)firstMax* secondMax;
        //    }

        //    int main()
        //    {
        //        int n;
        //        cin >> n;
        //        vector<int> numbers(n);
        //        for (int i = 0; i < n; ++i)
        //        {
        //            cin >> numbers[i];
        //        }

        //        int64_t result = MaxPairwiseProductFast(numbers);
        //        cout << result << "\n";
        //        return 0;
        //    }
        #endregion

        #region Python

        #endregion

        #endregion
    }
}

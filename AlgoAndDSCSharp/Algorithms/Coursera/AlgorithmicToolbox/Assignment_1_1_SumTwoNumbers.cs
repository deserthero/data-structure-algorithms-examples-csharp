using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoAndDSCSharp.Algorithms.Coursera.AlgorithmicToolbox
{
    public class Assignment_1_1_SumTwoNumbers
    {
        #region SumofTwoDigits Description
        // SumofTwoDigitsProblem Compute the sum of two single digit numbers.
        // Input: Two single digit numbers.
        // Output: The sum of these numbers.
        // Inputformat: Integers a and b on the same line(separated by a space).
        // Outputformat: The sum of a and b.Constraints. 0≤a, b≤9.
        // Sample Input: 9 7
        // Sample Output: 16
        // Timelimits(sec.): C 1 C++ 1 Java 1.5 Python 5 C# 1.5 Haskell 2 JavaScript 5 Ruby 5 Rust 1 Scala 3
        // Memorylimit. 512 Mb.
        #endregion

        #region C#
        public static int SumTwoNumbers(int a, int b)
        {
            return a + b;
        }
        #endregion

        #region C++
        //int sumTwoNumbers(int a, int b)
        //{
        //    return a + b;
        //}

        //int main()
        //{
        //    int a = 0;
        //    int b = 0;

        //    cin >> a;
        //    cin >> b;

        //    cout << sumTwoNumbers(a, b);

        //    return 0;
        //}

        #endregion

        #region JAVA
        //public static void main(String[] args)
        //{
        //    Scanner s = new Scanner(System.in);
        //    int a = s.nextInt();
        //    int b = s.nextInt();
        //    System.out.println(a + b);
        //}
        #endregion

        #region Python
        //# Uses python3
        //import sys
        // input = sys.stdin.read()
        // tokens = input.split()
        // a = int(tokens[0])
        // b = int(tokens[1])
        // print(a + b)
        #endregion
    }
}

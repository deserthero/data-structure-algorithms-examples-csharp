using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoAndDSCSharp.Algorithms.Recursion
{
    public class Recursion_3_PalindromeString
    {
        #region Problem Description
        // A palindrome is a word that is spelled the same forward and backward.
        // For example, rotor and redder are palindromes, but motor is not.
        #endregion

        #region Solution using recursion
        // We have 2 base cases and a recursion case to divide the problem to
        // sub problems till we reach one of the base cases.
        // First base case: Any string containing at most one letter is a palindrome. That's our base case: a string with exactly zero letters or one letter is a palindrome.
        // Second base case: We have a way to declare that a string is not a palindrome: when its first and last letters are different. We can think of this situation as another base case.
        // Recursion case: So here's how we can recursively determine whether a string is a palindrome. If the first and last letters differ, then declare that the string is not a palindrome. Otherwise, strip off the first and last letters, and determine whether the string that remains—the subproblem—is a palindrome. Declare the answer for the shorter string to be the answer for the original string. Once you get down to a string with no letters or just one letter, declare it to be a palindrome.
        #endregion

        #region pseudocode
        // If the string is made of no letters or just one letter, then it is a palindrome.
        // Otherwise, compare the first and last letters of the string.
        // If the first and last letters differ, then the string is not a palindrome.
        // Otherwise, the first and last letters are the same. Strip them from the string, and determine whether the string that remains is a palindrome. Take the answer for this smaller string and use it as the answer for the original string.
        #endregion

        #region C#

        public static bool IsStringPalindrome(string str)
        {
            if (str.Count() <= 1)
                return true;

            if (str[0] == str[str.Count() - 1])
            {
                str = str.Remove(0, 1);
                str = str.Remove(str.Count() - 1, 1);
                return IsStringPalindrome(str);
            }
            else
            {
                return false;
            }
        }

        #endregion

        #region Another solution from my mind without recursion
        public static bool IsStringPalindrome2(string str)
        {
            string firstHalf = string.Empty;
            string secondHalf = string.Empty;
            var center = 0;

            if (str.Count() <= 1)
                return true;
            else if (str.Count() % 2 == 0)
            {
                firstHalf = str.Substring(0, str.Count() / 2);
                secondHalf = str.Substring(str.Count() / 2);
            }
            else
            {
                center = (str.Count() - 1) / 2;
                firstHalf = str.Substring(0, center);
                secondHalf = str.Substring(center + 1);
            }

            //Console.WriteLine(firstHalf);
            //Console.WriteLine(secondHalf);

            for (int i = 0; i < firstHalf.Length; i++)
            {
                if (firstHalf[i] != secondHalf[firstHalf.Count() - 1 - i])
                    return false;
            }

            return true;
        }
        #endregion

    }
}

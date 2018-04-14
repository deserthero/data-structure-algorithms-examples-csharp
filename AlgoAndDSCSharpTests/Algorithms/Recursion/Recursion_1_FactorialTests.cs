using AlgoAndDSCSharp.Algorithms.Recursion;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AlgoAndDSCSharpTests.Algorithms.Recursion
{
    public class Recursion_1_FactorialTests
    {

        [Fact]
        public void Fibonacci_SendBasicCaseOfZero_ReturnsZero()
        {
            var result = Recursion_2_Fibonacci.FibonacciRecursion(0);
            result.Should().Be(0);
        }


        [Fact]
        public void Fibonacci_SendNegativeNumber_ReturnsTheNumber()
        {
            var result = Recursion_2_Fibonacci.FibonacciRecursion(-2);
            result.Should().Be(-2);
        }


        [Fact]
        public void Fibonacci_SendBigNumber_ReturnsTheResult()
        {
            var result = Recursion_2_Fibonacci.FibonacciRecursion(100);
            result.Should().Be(100);
        }

    }
}

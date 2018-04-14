using AlgoAndDSCSharp.Algorithms.Coursera.AlgorithmicToolbox;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AlgoAndDSCSharpTests.Algorithms.Coursera.AlgorithmicToolbox
{
    public class Assignment_2_1_FibonacciNumbersTests
    {
        [Fact]
        public void MaxPairwiseProductFast_PassAnSequanceContainsSameNumber_ReturnCorrectResult()
        {
            var result = Assignment_2_1_FibonacciNumbers.FibonacciTable(20);
            result.Should().Be(10946);
        }

    }
}

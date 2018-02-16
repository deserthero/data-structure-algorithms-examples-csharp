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
    public class Assignment_1_1_SumTwoNumbersTests
    {
        [Fact]
        public void SumTwoNumbers_SendNegativeParameters_ReturnCorrectResult()
        {
            var result = Assignment_1_1_SumTwoNumbers.SumTwoNumbers(-1, -2);
            result.Should().Be(-3);
        }
    }
}

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
    public class Assignment_1_2_MaximumPairwiseProductTests
    {
        [Fact]
        public void MaxPairwiseProductFast_PassAnSequanceContainsSameNumber_ReturnCorrectResult()
        {
            var result = Assignment_1_2_MaximumPairwiseProduct.MaxPairwiseProductFast(new int[] { 1, 1, 1, 1, 1 });
            result.Should().Be(1);
        }

        [Fact]
        public void MaxPairwiseProductFast_PassAnSequanceContainsOnlyZeros_ReturnCorrectResult()
        {
            var result = Assignment_1_2_MaximumPairwiseProduct.MaxPairwiseProductFast(new int[] { 0, 0, 0, 0, 0 });
            result.Should().Be(0);
        }


        [Fact]
        public void MaxPairwiseProductFast_PassAnSequanceContainsNegativeNumbers_ReturnCorrectResult()
        {
            var result = Assignment_1_2_MaximumPairwiseProduct.MaxPairwiseProductFast(new int[] { -1, 1, -20, 2, 0 });
            result.Should().Be(2);
        }

        [Fact]
        public void MaxPairwiseProductFast_PassAnSequanceContainsOneNumber_ThrowsAnException()
        {

            Action result = () => Assignment_1_2_MaximumPairwiseProduct.MaxPairwiseProductFast(new int[] { 1 });

            result.Should().Throw<Exception>()
                .WithMessage("No Pairs to product");
        }

    }
}

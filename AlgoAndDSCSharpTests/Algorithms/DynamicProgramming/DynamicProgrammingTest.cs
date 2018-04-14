using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AlgoAndDSCSharpTests.Algorithms.DynamicProgramming
{
    public class DynamicProgrammingTest
    {
        [Fact]
        public void tttt()
        {
            AlgoAndDSCSharp.Algorithms.DynamicProgramming.DynamicProgramming di = new AlgoAndDSCSharp.Algorithms.DynamicProgramming.DynamicProgramming();
            int[,] n = new int[3, 3] { {1,2,3 }, {3,4,5 }, { 6,7,8} };
            var result = di.GetMaxPathTopDown(0, 0, n);
            result.Should().Be(0);
        }

    }
}

using Xunit;
using Leetcode.Array;

namespace Leetcode.Tests.Array
{
    public class TwoSumTest
    {
        [Fact]
        public void TwoSumSolution_ShoulReturnZeroAndOne()
        {
            var nums = new[] { 2, 7, 11, 15 };
            var target = 9;

            var result = TwoSum.TwoSumSolution(nums, target);

            var expectedResult = new int[] { 0, 1 };

            for(int i = 0; i < result.Length; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }

        [Fact]
        public void TwoSumSolution_ShouldReturnNull()
        {
            var nums = new[] { 2, 7, 11, 15 };
            var target = 10;

            var result = TwoSum.TwoSumSolution(nums, target);

            Assert.Null(result);
        }
    }
}

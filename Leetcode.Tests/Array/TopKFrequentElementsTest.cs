using Xunit;
using Leetcode.Array;

namespace Leetcode.Tests.Array
{
    public class TopKFrequentElementsTest
    {
        [Fact]
        public void TopKFrequent_ShouldReturnOneAndTwo()
        {
            int[] nums = { 1, 1, 1, 2, 2, 3 };
            int k = 2;

            var result = TopKFrequentElements.TopKFrequent(nums, k);

            var expectedResult = new int[] { 1, 2 };

            Assert.Equal(expectedResult.Length, result.Length);

            for (int i = 0; i < result.Length; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }
    }
}

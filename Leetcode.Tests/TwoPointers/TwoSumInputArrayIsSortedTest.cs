using Xunit;
using Leetcode.TwoPointers;

namespace Leetcode.Tests.TwoPointers
{
    public class TwoSumInputArrayIsSortedTest
    {
        [Fact]
        public void TwoSumSortedArray_ShouldReturnOneAndTwo()
        {
            // Arrange
            int[] numbers = new int[] { 2, 7, 11, 15 };
            int target = 9;

            // Act
            int[] result = TwoSumInputArrayIsSorted.TwoSumSortedArray(numbers, target);
            int[] expectedResult = new int[] { 1, 2 };

            // Assert
            Assert.Equal(expectedResult.Length, result.Length);

            for (int i = 0; i < expectedResult.Length; i++) 
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }
    }
}

using Xunit;
using Leetcode.Array;

namespace Leetcode.Tests.Array
{
    public class LongestConsecutiveSequenceTest
    {
        [Fact]
        public void LongestConsecutive_ShouldReturnFour()
        {
            // Arrange
            int[] nums = new int[] { 100, 4, 200, 1, 2, 3 };

            // Act
            int result = LongestConsecutiveSequence.LongestConsecutive(nums);
            int expectedResult = 4;

            // Assert
            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void LongestConsecutive_ShouldReturnNine()
        {
            // Arrange
            int[] nums = new int[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 };

            // Act
            int result = LongestConsecutiveSequence.LongestConsecutive(nums);
            int expectedResult = 9;

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}

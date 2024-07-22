using Xunit;
using Leetcode.Array;

namespace Leetcode.Tests.Array
{
    public class ContainsDuplicateTest
    {
        [Fact]
        public void CheckContainsDuplicate_ShouldReturnTrue()
        {
            // Arrange
            var nums = new int[] { 1, 2, 3, 1 };

            // Act
            var result = ContainsDuplicate.CheckContainsDuplicate(nums);

            // Assert
            var expectedResult = true;

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void CheckContainsDuplicate_ShouldReturnFalse()
        {
            var nums = new int[] { 5, 7, 8 };

            var result = ContainsDuplicate.CheckContainsDuplicate(nums);

            var expectedResult = false;

            Assert.Equal(expectedResult, result);
        }
    }
}

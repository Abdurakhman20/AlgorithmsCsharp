using Xunit;
using Leetcode.TwoPointers;

namespace Leetcode.Tests.TwoPointers
{
    public class ValidPalindromeTest
    {
        [Fact]
        public void IsPalindrome_ShouldReturnTrue()
        {
            // Arrange
            string s = "A man, a plan, a canal: Panama";

            // Act
            bool result = ValidPalindrome.IsPalindrome(s);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_ShouldReturnFalse()
        {
            // Arrange
            string s = "race a car";

            // Act
            bool result = ValidPalindrome.IsPalindrome(s);

            // Assert
            Assert.False(result);
        }
    }
}

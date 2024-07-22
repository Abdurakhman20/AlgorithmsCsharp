using Xunit;
using Leetcode.Array;

namespace Leetcode.Tests.Array
{
    public class ValidAnagramTest
    {
        [Fact]
        public void IsAnagram_ShouldReturnTrue()
        {
            string s = "anagram";
            string t = "nagaram";

            var result = ValidAnagram.IsAnagram(s, t);

            Assert.True(result);
        }

        [Fact]
        public void IsAnagram_ShouldReturnFalse()
        {
            string s = "rat";
            string t = "car";

            var result = ValidAnagram.IsAnagram(s, t);

            Assert.False(result);
        }
    }
}

using Xunit;
using Leetcode.Array;
using System.Collections.Generic;
using System.Linq;

namespace Leetcode.Tests.Array
{
    public class GroupAnagramsTest
    {
        [Fact]
        public void GroupAnagramsSolution_ShouldReturnGroup()
        {
            // Arrange
            string[] strs = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };

            // Act
            var result = GroupAnagrams.GroupAnagramsSolution(strs);

            // Assert
            var expectedResult = new List<List<string>>
            {
                new List<string> { "eat", "tea", "ate" },
                new List<string> { "tan", "nat" },
                new List<string> { "bat" }
            };

            Assert.Equal(expectedResult.Count, result.Count);

            foreach (var group in expectedResult)
            {
                bool groupFound = false;

                foreach (var resultGroup in result)
                {
                    if (group.Count == resultGroup.Count && !group.Except(resultGroup).Any())
                    {
                        groupFound = true;
                        break;
                    }
                }

                Assert.True(groupFound, $"Group {string.Join(",", group)} not found in result");
            }
        }
    }
}

using Xunit;
using Leetcode.LinkedList;
using Leetcode.Utils;

namespace Leetcode.Tests.LinkedList
{
    public class RemoveDuplicatesFromSortedListTest
    {
        [Fact]
        public void DeleteDuplicates_ShouldRemoveDuplicates()
        {
            // Arrange
            var list = new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(3)))));

            // Act
            var result = RemoveDuplicatesFromSortedList.DeleteDuplicates(list);

            //Assert
            var expectedValues = new int[] { 1, 2, 3 };
            var current = result;
            foreach (var value in expectedValues)
            {
                Assert.NotNull(current);
                Assert.Equal(value, current.val);
                current = current.next;
            }
            Assert.Null(current);
        }
        [Fact]
        public void DeleteDuplicates_ShouldHandleEmptyList()
        {
            // Arrange
            ListNode list = null;

            // Act
            var result = RemoveDuplicatesFromSortedList.DeleteDuplicates(list);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void DeleteDuplicates_ShouldHandleSingleElementList()
        {
            // Arrange
            var list = new ListNode(1);

            // Act
            var result = RemoveDuplicatesFromSortedList.DeleteDuplicates(list);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(1, result.val);
            Assert.Null(result.next);
        }

        [Fact]
        public void DeleteDuplicates_ShouldHandleListWithNoDuplicates()
        {
            // Arrange
            var list = new ListNode(1, new ListNode(2, new ListNode(3)));

            // Act
            var result = RemoveDuplicatesFromSortedList.DeleteDuplicates(list);

            // Assert
            var expectedValues = new int[] { 1, 2, 3 };
            var current = result;
            foreach (var expectedValue in expectedValues)
            {
                Assert.NotNull(current);
                Assert.Equal(expectedValue, current.val);
                current = current.next;
            }
            Assert.Null(current);
        }
    }
}

using Xunit;
using Leetcode.LinkedList;
using Leetcode.Utils;

namespace Leetcode.Tests.LinkedList
{
    public class MergeTwoSortedListsTest
    {
        [Fact]
        public void MergeTwoLists_ShouldMergeLists()
        {
            // Arrange
            var list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
            var list2 = new ListNode(1, new ListNode(3, new ListNode(4)));

            // Act
            var result = MergeTwoSortedLists.MergeTwoLists(list1, list2);

            // Assert
            var expectedValues = new int[] { 1, 1, 2, 3, 4, 4 };
            var current = result;
            foreach (var value in expectedValues)
            {
                Assert.NotNull(current);
                Assert.Equal(value, current.val);
                current = current.next;
            }
            Assert.Null(current);
        }
    }
}

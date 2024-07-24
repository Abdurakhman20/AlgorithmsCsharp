using Xunit;
using Leetcode.Array;

namespace Leetcode.Tests.Array
{
    public class ProductOfArrayExceptSelfTest
    {
        [Fact]
        public void ProductExceptSelf_ShouldReturnProduct()
        {
            // Arrange
            int[] nums = [ 1, 2, 3, 4 ];

            // Act
            int[] result = ProductOfArrayExceptSelf.ProductExceptSelf(nums);
            int[] expextedResult = [ 24, 12, 8, 6 ];

            // Assert
            Assert.Equal(expextedResult.Length, result.Length);

            for (int i = 0; i < result.Length; i++) 
            {
                Assert.Equal(expextedResult[i], result[i]);
            }
        }
    }
}

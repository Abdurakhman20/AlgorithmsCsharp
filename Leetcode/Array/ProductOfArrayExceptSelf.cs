
namespace Leetcode.Array
{
    public class ProductOfArrayExceptSelf
    {
        public static int[] ProductExceptSelf(int[] nums)
        {
            int N = nums.Length;
            
            int[] result = new int[N];
            result[0] = 1;

            for(int i = 1; i < N; i++)
            {
                result[i] = result[i - 1] * nums[i - 1];
            }

            int prefix = 1;

            for(int i = N - 1; i >= 0; i--)
            {
                result[i] = result[i] * prefix;
                prefix = prefix * nums[i];
            }

            return result;
        }
    }
}

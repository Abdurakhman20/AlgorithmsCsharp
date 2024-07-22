
namespace Leetcode.Array
{
    public class TwoSum
    {
        public static int[] TwoSumSolution(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for(int i = 0; i < nums.Length; i++)
            {
                if(dict.ContainsKey(target - nums[i]))
                {
                    return new int[] { dict[target - nums[i]], i};
                }

                if (!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], i);
                }
            }

            return null;
        }
    }
}

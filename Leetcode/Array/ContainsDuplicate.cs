
namespace Leetcode.Array
{
    public class ContainsDuplicate
    {
        public static bool CheckContainsDuplicate(int[] nums)
        {
            HashSet<int> set = new HashSet<int>(nums);

            return set.Count != nums.Length;
        }
    }
}

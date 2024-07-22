
namespace Leetcode.Array
{
    public class LongestConsecutiveSequence
    {
        public static int LongestConsecutive(int[] nums)
        {
            HashSet<int> set = new HashSet<int>(nums);
            int count = 0;

            foreach (var num in set)
            {
                if (set.Contains(num - 1)) continue;

                int length = 0;
                while (set.Contains(num + length)) length += 1;
                count = Math.Max(count, length);
            }

            return count;
        }
    }
}

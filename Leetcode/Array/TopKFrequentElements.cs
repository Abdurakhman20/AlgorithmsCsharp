
namespace Leetcode.Array
{
    public class TopKFrequentElements
    {
        public static int[] TopKFrequent(int[] nums, int k)
        {
            var dict = new Dictionary<int, int>();

            foreach(int num in nums)
            {
                if(!dict.ContainsKey(num))
                {
                    dict.Add(num, 0);
                }

                dict[num]++;
            }

            var result = dict.OrderByDescending(el => el.Value).Take(k).Select(el => el.Key).ToArray();

            return result;
        }
    }
}

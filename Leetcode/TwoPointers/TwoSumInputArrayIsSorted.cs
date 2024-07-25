﻿namespace Leetcode.TwoPointers
{
    public class TwoSumInputArrayIsSorted
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int start = 0;
            int end = numbers.Length - 1;
            bool isFound = false;

            while (start < end && !isFound)
            {
                int sum = numbers[start] + numbers[end];

                if (sum == target)
                {
                    isFound = true;
                    return new int[] { start + 1, end + 1 };
                }

                if (sum < target)
                {
                    start++;
                }

                else
                {
                    end--;
                }
            }

            return null;
        }
    }
}

using System.Collections;
using Leetcode.Array;

namespace Algorithms 
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 100, 4, 200, 1, 3, 2 };
            var res = LongestConsecutiveSequence.LongestConsecutive(arr);
            Console.WriteLine(res);
        }
    } 
}

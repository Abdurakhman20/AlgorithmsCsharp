using System.Collections;

namespace Algorithms 
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 90, 9, 111, 11, 1, 0 };
            Sort.MergeSort(array, 0, array.Length - 1);

            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        }
    } 
}

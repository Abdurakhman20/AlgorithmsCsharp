using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Search
    {
        public static int FindMaxElementInArray(int[] array)
        {
            int max = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        // В этом алгоритме простого поиска, выход из цикла осуществляется по двум условиям: 
        // 1 - элемент найден, 2 - достигнут конец массива
        public static int SimpleSearch(int[] array, int x)
        {
            int L = array.Length;
            int i = 0;

            while (i < L && array[i] != x)
            {
                i++;
            }

            if (i < L) return i;
            else return -1;
        }

        // Проверку выхода за границу массива можно опустить, если искомый элемент гарантированно находится в массиве
        public static int SearchWithBarrier(int[] array, int x)
        {
            /*
             * Допустим дан массив [1, 2, 3, 4, 66, 77, 88] (Length = 7), искомый элемент 67
             * Увеличиваем размер массива на 1, и ставим в качестве барьера искомый элемент
             * [1, 2, 3, 4, 66, 77, 88, 67] (Length = 8)
             * Проходимся по массиву, если мы дошли до барьера, значит мы не нашли элемент. if (i < L - 1)
             * Поэтому возвращаем -1
             */
            int L = array.Length;

            // Увеличиваем размер массива на 1
            Array.Resize<int>(ref array, ++L);
            // Устанавливаем барьер
            array[L - 1] = x;
            int i = 0;
            // Без проверки выхода за границу массива
            while (array[i] != x)
            {
                i++;
            }
            if (i < L - 1) return i;
            else return -1;
        }

        public static int BinarySearch(int[] sortedArray, int target)
        {
            int start = 0;
            int end = sortedArray.Length;
            int middle;

            while(start < end)
            {
                middle = (start + end) / 2;

                if (sortedArray[middle] == target)
                {
                    return middle;
                } 
                else if (sortedArray[middle] < target) 
                {
                    start = middle + 1;
                }
                else
                {
                    end = middle - 1;
                }
            }

            return -1;
        }
    }
}

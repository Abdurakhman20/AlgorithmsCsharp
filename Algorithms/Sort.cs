using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Sort
    {
        public static void BubbleSort(int[] array)
        {
            int tmp;

            for (int i = 0; i < array.Length - 1; i++) 
            {
                for(int j = 0; j < array.Length - i - 1; j++)
                {
                    if(array[j] > array[j + 1])
                    {
                        tmp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = tmp;
                    }
                }
            }
        }

        public static void InsertionSort(int[] array)
        {
            for(int i = 1; i < array.Length; i++)
            {
                int tmp = array[i];
                int j = i - 1;

                while(j >= 0 && array[j] > tmp)
                {
                    array[j + 1] = array[j];
                    j -= 1;
                }

                array[j + 1] = tmp;
            }
        }

        public static void SelectionSort(int[] array)
        {
            
            for(int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int tmp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = tmp;
            }
        }
    }
}

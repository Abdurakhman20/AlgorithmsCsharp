using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

        public static void MergeSort(int[] array, int left, int right)
        {
            if(left < right)
            {
                int middle = left + (right - left) / 2;

                MergeSort(array, left, middle);
                MergeSort(array, middle + 1, right);

                Merge(array, left, middle, right);
            }
        }
        private static void Merge(int[] array, int left, int middle, int right)
        {
            int leftArrayLength = middle - left + 1;
            int rightArrayLength = right - middle;


            int[] leftArray = new int[leftArrayLength];
            int[] rightArray = new int[rightArrayLength];

            int i;
            int j;
            
            for(i = 0; i < leftArrayLength; i++)
            {
                leftArray[i] = array[left + i];
            }

            for(j = 0; j < rightArrayLength; j++)
            {
                rightArray[j] = array[middle + 1 + j];
            }

            int k = left;
            i = 0;
            j = 0;

            while (i < leftArrayLength && j < rightArrayLength)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    array[k] = leftArray[i];
                    i++;
                }
                else
                {
                    array[k] = rightArray[j];
                    j++;
                }
                k++;
            }

            while (i < leftArrayLength)
            {
                array[k] = leftArray[i];
                i++;
                k++;
            }

            while (j < rightArrayLength)
            {
                array[k] = rightArray[j];
                j++;
                k++;
            }
        }
    }
}

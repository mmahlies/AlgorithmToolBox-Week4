using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 9,5, 3,4};
            DoMergeSort(array, 0, array.Length -1);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        private static void DoMergeSort(int[] array, int l, int h)
        {
            if (h > l)  
            {
                int m = ((h - l) / 2) + l;
                DoMergeSort(array, l, m);
                DoMergeSort(array, m + 1, h);
                DoMerge(array, l, h, m);
            }
        }
                          // merge with sort
        private static void DoMerge(int[] array, int l, int h, int m)
        {
            int[] arr1 = new int[m - l + 1];
            int[] arr2 = new int[h - m];
           // int[] arr3 = new int[h - l + 1];

            int arr1Index = 0;
            int arr2Index = 0;
            int bigArrayIndex = l;

            
            for (int i = l; i <= m; i++)
            {
                arr1[arr1Index] = array[i];
                arr1Index++;
            }
            arr1Index = 0;
            
            for (int j = m + 1; j <= h; j++)
            {
                arr2[arr2Index] = array[j];
                arr2Index++;
            }
            arr2Index = 0;
            
            while (arr1Index < arr1.Length && arr2Index < arr2.Length)
            {
                if (arr1[arr1Index] > arr2[arr2Index])
                {
                    array[bigArrayIndex] = arr2[arr2Index];
                    arr2Index++;
                }
                else
                {
                    array[bigArrayIndex] = arr1[arr1Index];
                    arr1Index++;
                }
                bigArrayIndex++;
            }
            while (arr1Index < arr1.Length)
            {
                array[bigArrayIndex] = arr1[arr1Index];
                arr1Index++;
                bigArrayIndex++;
            }
            while (arr2Index < arr2.Length)
            {
                array[bigArrayIndex] = arr2[arr2Index];
                arr2Index++;
                bigArrayIndex++;
            }
        }




       
    }
}

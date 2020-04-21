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
            //   int[] array = new int[] { 9, 5, 3, 4, 1  ,3,2,6,9,8,7,4,2,3,6,9,8,7,4,5,6,2,6,};
               int[] array = new int[] { 0,5,6,4,3,2,-1,-5,-4,-2,-3,10,7,9,8,1};
            // top down
            DoMergeSort(array, 0, array.Length -1);
            // down up
            //   DoMergeSort(array);
            //  Sort(array, 0, array.Length - 1);
       //     MergeSort.Sort(array);

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }


        public static void Sort(int[] array, int lo, int hi)
        {
            if (hi <= lo) return;
            int mid = lo + (hi - lo) / 2;
            Sort(array, lo, mid); // Sort left half.
            Sort(array, mid + 1, hi);
            DoMerge(array, lo, hi, mid);
        }



        public static void DoMergeSort(int[] array, int lo, int h)
        {
            if (h > lo)
            {
                int m = ((h - lo) / 2) + lo;
                DoMergeSort(array, lo, m);
                DoMergeSort(array, m + 1, h);
                // because we merge to sorted sub arrays we can make sure from the both is order so save the cost of this tep
                if (array[m] > array[m+1])
                {
                    DoMerge(array, lo, h, m);
                }
               
            }
        }


        // with itreative appraoch
        //boutton up merge sort
        public static void DoMergeSort(int[] array)
        {
            int n = array.Length;
            // 1 2 4
            for (int sz = 1; sz < n; sz = sz *2 )
            {
                for (int lo = 0; lo < n  ; lo = sz*2)
                {
                    int h = (lo + (sz*2) - 1) < n ? (lo + (sz * 2) - 1) : n-1;
                    int mid = (lo + sz -1) < n ? (lo + sz - 1) : ((h-lo)/2 )+ lo;
                    DoMerge(array, lo, h, mid);
                }
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

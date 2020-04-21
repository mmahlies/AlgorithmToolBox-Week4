using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellSort
{
    public class Shell
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 5,3,4,2 };
            insertionSortWithoutExchanges(array);
            
             var result = IsSort(array);
            Console.WriteLine(result);
        }

        public static void Sort(int[] a)
        { // Sort a[] into increasing order.
            int N = a.Length;
            int h = 1;
            while (h < N / 3) h = 3 * h + 1; // 1, 4, 13, 40, 121, 364, 1093, ...
          while (h >= 1)
            { // h-sort the array.
                for (int i = h; i < N; i++)
                { // Insert a[i] among a[i-h], a[i-2*h], a[i-3*h]... .
                    for (int j = i; j >= h; j -= h)
                        if ((a[j] < a[j - h]))
                        {
                            Exch(a, j, j - h);
                        }
                }
                h = h / 3;
            }
        }
        private static void insertionSortWithoutExchanges(int[] array)
        {

            for (int i = 0; i < array.Length; i++)
            {
                // save current element 
                // we want to put this element in it's position relative to the left side
                int aux = array[i];

                int j;

                for (j = i; j > 0 && aux.CompareTo(array[j - 1]) < 0; j--)
                {
                    array[j] = array[j - 1];
                }

                array[j] = aux;
            }

        }

        //public static void Sort(int[] a)
        //{ // Sort a[] into increasing order.
        //    int N = a.Length;
        //    int h = 1;
        //    while (h < N / 3) h = 3 * h + 1; // 1, 4, 13, 40, 121, 364, 1093, ...
        //    while (h >= 1)
        //    { // h-sort the array.
        //        for (int i = h; i < N; i++)
        //        { // Insert a[i] among a[i-h], a[i-2*h], a[i-3*h]... .
        //            for (int j = i; j >= h && (a[j] < a[j - h]); j -= h)
        //                Exch(a, j, j - h);
        //        }
        //        h = h / 3;
        //    }
        //}

        // for echange 
        private static void Exch(int[] a, int j, int v)
        {
            int temp = a[j];
            a[j] = a[v];
            a[v] = temp;
        }


        public static bool IsSort(int[] arr)
        {

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] > arr[i])
                {
                    return false;
                }
            }

            return true;

        }
    }
}
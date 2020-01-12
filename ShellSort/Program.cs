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
            int[] array = new int[] { 10,9,8,7,6,5,4,3,2,1 };
            Sort(array);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        public static void Sort(int[] a)
        { // Sort a[] into increasing order.
            int N = a.Length;
            int h = 3;
            //  while (h < N / 3) h = 3 * h + 1; // 1, 4, 13, 40, 121, 364, 1093, ...
            while (h >= 1)
            { // h-sort the array.
                for (int i = h; i < N; i++)
                { // Insert a[i] among a[i-h], a[i-2*h], a[i-3*h]... .
                    for (int j = i; j >= h && (a[j] < a[j - h]); j -= h)
                        Exch(a, j, j - h);
                }
                h--;
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
    }
}
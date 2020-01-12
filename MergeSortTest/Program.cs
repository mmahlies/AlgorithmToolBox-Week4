using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortTest
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] result = MergeSortortBU(new int[] { 3, 5, 2, 1 });

            Console.Read();
        }                                                              


        //interface for merge sort
        private static int[] MergeSort(int[] v)
        {

            int[] aux = new int[v.Length];
            MergeSort(ref v, aux, 0, v.Length - 1);
            return v;
        }

        public static int[] MergeSortortBU(int[] a)
        { // Do lg N passes of pairwise merges.
            int N = a.Length;
            int[] aux = new int[a.Length];
            for (int sz = 1; sz < N; sz = sz + sz) // sz: subarray size
                for (int lo = 0; lo < N - sz; lo += sz + sz) // lo: subarray index
                {
                    var high = Math.Min((lo + sz + sz - 1), (N - 1));
                    int mid = lo + sz - 1;
                    Merge(ref a, aux, lo, mid, high);
                }
            //for (int SubarraySize = 1; SubarraySize < a.Length; SubarraySize += SubarraySize)
            //{
            //    for (int lo = 0; lo < N-SubarraySize; lo=SubarraySize+SubarraySize)
            //    {

            //            int hight = lo + (SubarraySize * 2);
            //        int middle = (hight - lo);
            //        Merge(a, aux, lo, );
            //    }
            //}


            return a;
        }

        private static void MergeSort(ref int[] arr, int[] aux, int low, int high)
        {
            // base case
            if (low >= high)
            {
                return;
            }

            // recursive step
            int middle = low + (high - low) / 2;
            MergeSort(ref arr, aux, low, middle);
            MergeSort(ref arr, aux, middle + 1, high);

            Merge(ref arr, aux, low, middle, high);
        }

        private static void Merge(ref int[] arr, int[] aux, int low, int middle, int high)
        {

            int indexArr1 = low;
            int indexArr2 = middle + 1;
            int generalIndex = low;
            // fill aux with data
            for (int i = low; i <= high; i++)
            {
                aux[i] = arr[i];
            }

            for (int i = low; i <= high; i++)
            {
                if (indexArr1 > middle) arr[generalIndex++] = aux[indexArr2++];
                else if (indexArr2 > high) arr[generalIndex++] = aux[indexArr1++];
                else if (aux[indexArr1] > aux[indexArr2]) arr[generalIndex++] = aux[indexArr2++];
                else if (aux[indexArr1] < aux[indexArr2]) arr[generalIndex++] = aux[indexArr1++];
            }



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
             int[] array = new int[] { 0, 5, 4, 9, 8, 1, 7, 2, 3 };
        //    int[] array = new int[] { 1, 3, 2, 3, 2, 1, 1, 2, 3 };

            SortingAlgorithm.InsertionSort(array);
            var noOfExchange = SortingAlgorithm.noOfEchange;
            Console.WriteLine();

        }


        public class SortingAlgorithm
        {
            public static int noOfEchange = 0;
            public static void InsertionSort(int[] array)
            {
                // 1:n
                for (int i = 1; i < array.Length; i++)
                {
                    // for each i compare by the previous elements
                    for (int j = i; j > 0 && array[j] < array[j - 1]; j--)
                    {

                        // exchange
                        Exch(array, j, j - 1);
                        noOfEchange++;
                        // break;


                    }
                }
            }

            // for echange 
            private static void Exch(int[] a, int j, int v)
            {
                int temp = a[j];
                a[j] = a[v];
                a[v] = temp;
            }
        }
        // insertion sort method

    }



}

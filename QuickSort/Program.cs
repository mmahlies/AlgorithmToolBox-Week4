using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 4, 3, 5, 2,6,9,8,10 , 0 , 11 , 13 , 12};
             QuickSortFromRobertSedwerg.QuickSort(array, 0, array.Length - 1);
            //DoQuickSort(array, 0, array.Length - 1, isRandom: true);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }

        private static void DoQuickSort(int[] array, int l, int r, bool isRandom)
        {
            if (l < r)
            {
                int pi = Partion(array, l, r, isRandom);
                DoQuickSort(array, l, pi - 1, isRandom);
                DoQuickSort(array, pi + 1, r, isRandom);
            }

        }

        private static int Partion(int[] array, int l, int r, bool isRandom)
        {
            int pivot;
            int pivotIndex = 0;
            //if (isRandom)
            //{
            //    Random d = new Random();
            //    pivotIndex = d.Next(l, r);
            //    pivot = array[pivotIndex];
            //}
            //else
            {
                pivot = array[r];
                pivotIndex = r;
            }

            int smallGroupIndexPlusOne = l;
            for (int i = l; i < r; i++)
            {
                //if (isRandom && i == pivotIndex)
                //{
                //    continue;
                //}   
                if (array[i] < pivot)
                {
                    Swap(array, smallGroupIndexPlusOne, i);
                    smallGroupIndexPlusOne++;
                    //if (isRandom && smallGroupIndexPlusOne == pivotIndex)
                    //{
                    //    smallGroupIndexPlusOne++;    
                    //}
                }
            }

            Swap(array, smallGroupIndexPlusOne, pivotIndex);


            return smallGroupIndexPlusOne;
        }
        private static void Swap(int[] array, int old, int smallestIdex)
        {
            int temp = 0;
            temp = array[old];
            array[old] = array[smallestIdex];
            array[smallestIdex] = temp;
        }


    }
}

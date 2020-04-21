using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    public class MergeSort
    {
      static  int[] aux;
        public static void Sort(int[] array)
        {

            aux = new int[array.Length];
            Sort(array, 0, array.Length - 1);
        }

        /// <summary>
        /// up down merge sort
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// <param name="lo"></param>
        /// <param name="hi"></param>
        private static void Sort(int[] array, int lo, int hi)
        {
            // base case
            if (lo >= hi)
                return;

            int mid = (hi - lo) / 2 + lo;
            // devide
            Sort(array, lo, mid);
            // devide
            Sort(array, mid + 1, hi);


            //conqure
            Merge(array, lo, mid, hi);

        }

        //merge two sorted array
        private static void Merge(int[] array, int lo, int mid, int hi)
        {
            int arrayScopeLength = hi - lo + 1;
            

            // copy all array scope to the aux            
            for (int i = lo; i <= hi; i++)
            {
                aux[i] = array[i];                
            }


            int subArray1Index = lo;            
            int subArray2Index = mid+ 1;

            for (int i = lo; i <= hi; i++)
            {
                if (subArray1Index > mid)
                    array[i] = aux[subArray2Index++];
                else if (subArray2Index > hi)
                    array[i] = aux[subArray1Index++];
                else if (aux[subArray1Index] < aux[subArray2Index])
                    array[i] = aux[subArray1Index++];
                else                
                    array[i] = aux[subArray2Index++];                
            }
        }
    }
}

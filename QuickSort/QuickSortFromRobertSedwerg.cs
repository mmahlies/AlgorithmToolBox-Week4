using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    public class QuickSortFromRobertSedwerg
    {

        public static void QuickSort(int[] array, int low, int high)
        {
            //base case
            if (low >= high)
            {
                return;
            }
            // partition
            int p = Partion(array, low ,high);

            // sort left half of the array
            QuickSort(array, low, p - 1);
            // sort rigt half of the array
            QuickSort(array, p + 1, high);
        }



        // to find partion of this array   and return ondex of partion
        private static int Partion(int[] array, int low, int high)
        {
            // shaffle array

            int pIndex = low;
            int iIndex = low + 1 <= high ? low + 1 :  high;
            int jIndex = high;

            while (true)
            {
                // search in lower side
                while (array[pIndex] > array[iIndex])
                {
                    // increase i
                    iIndex++;
                    if (iIndex >= high)
                        break;
                }
                // search in highrt side
                while (array[pIndex] < array[jIndex])
                {
                    //              decrease j
                    jIndex--;
                    if (jIndex == low)
                        break;
                }

                // reach finish
                if (iIndex >= jIndex)
                {
                    Swap(array, pIndex, jIndex);
                    return jIndex;
                }


                Swap(array, iIndex, jIndex);
            }
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

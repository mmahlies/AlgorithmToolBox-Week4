using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowCloseADataisToBeingSorted
{
    class Program
    {
        static void Main(string[] args)
        {
           // int[] array = new int[] { 2, 3 , 9 , 2 ,9 };
            // count the inversion count 
            int inversionCount = 0;
            int intputLenght = int.Parse(Console.ReadLine());
            string[] inputRow = Console.ReadLine().Split(' ');
            int[] array = new int[intputLenght];
            for (int i = 0; i < intputLenght; i++)
            {
                array[i] = int.Parse(inputRow[i]);
            }
        
            DoMergeSort(array, 0, array.Length - 1, ref inversionCount);
            Console.WriteLine(inversionCount.ToString());

        }

        private static void DoMergeSort(int[] array, int low, int high, ref int inversionCount)
        {
            if (low < high)
            {
                int mid = ((high - low) / 2) + low ;
                DoMergeSort(array, low, mid, ref inversionCount);
                DoMergeSort(array, mid + 1, high, ref inversionCount);
                Sort(array, low, high, mid, ref inversionCount);
            }
        }

        private static void Sort(int[] array, int low, int high, int mid, ref int inversionCount)
        {
            int[] temp1 = new int[mid - low + 1];
            int[] temp2 = new int[high - mid];
            int indexTemp1 = 0, indexTemp2 = 0;
            int indexArray = low;
            //fill temp array
            for (int i = low; i <= mid ; i++)
                temp1[indexTemp1++] = array[i];

            // reset the counter
            indexTemp1 = 0;

            for (int i = mid+1; i <= high; i++)
                temp2[indexTemp2++] = array[i];
            
            // reset the counter
            indexTemp2 = 0;

            while (indexTemp1 < temp1.Length && indexTemp2 < temp2.Length)
            {
                if (temp1[indexTemp1] <= temp2[indexTemp2])
                    array[indexArray++] = temp1[indexTemp1++];
                else
                {
                    inversionCount += (temp1.Length -indexTemp1);
                    array[indexArray++] = temp2[indexTemp2++];
                }
            }
           
            while (indexTemp1 < temp1.Length)
            {               
                array[indexArray++] = temp1[indexTemp1++];
            }
            while (indexTemp2 < temp2.Length)
            {
                array[indexArray++] = temp2[indexTemp2++];
            }
        }
    }
}

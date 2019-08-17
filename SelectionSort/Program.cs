using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 5, 6, 9, 8, 2, 1 , 3,4,7};
            DoSelectionSort(array);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        private static void DoSelectionSort(int[] array)
        {
            int smallestIdex ;
            for (int i = 0; i < array.Length; i++)
            {
                smallestIdex = i;
                for (int j = i; j < array.Length; j++)
                {
                    if (array[j] < array[smallestIdex] )
                    {
                        smallestIdex = j;
                    }
                }
                Swap(array, i, smallestIdex);
            }
        }

        private static void Swap(int[] array, int i, int smallestIdex)
        {
            int temp = 0;
            temp = array[i];
            array[i] = array[smallestIdex];
            array[smallestIdex] = temp;
        }
    }
}

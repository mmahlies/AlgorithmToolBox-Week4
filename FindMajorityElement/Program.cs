using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMajorityElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int intputLenght = int.Parse(Console.ReadLine());
            string[] inputRow = Console.ReadLine().Split(' ');
            int[] dataSet = new int[intputLenght];
            for (int i = 0; i < intputLenght; i++)
            {
                dataSet[i] = int.Parse(inputRow[i]);
            }
            DoMergeSort(dataSet, 0, dataSet.Length - 1);

            int result = CalcMajority(dataSet);
            Console.WriteLine(result.ToString());
            }

        private static int CalcMajority(int[] dataSet)
        {
            if (dataSet.Length ==1)
            {
                return 1;
            }
            int result = 0;
            int counter = 1;
            int majorityLevel = (dataSet.Length / 2) +1 ;
            for (int i = 0; i < dataSet.Length-1; i++)
            {
                if (dataSet[i] == dataSet[i+1])
                {
                    counter++;
                    if (counter == majorityLevel)
                    {
                        result++;
                        return result;
                    }
                }
                else
                {
                    counter = 1;
                }
            }
            return result;
        }
        private static void DoMergeSort(int[] array, int l, int h)
        {
            if (h > l)
            {
                int m = ((h - l) / 2) + l;
                DoMergeSort(array, l, m);
                DoMergeSort(array, m + 1, h);
                DoMerge(array, l, h, m);
            }
        }

        private static void DoMerge(int[] array, int l, int h, int m)
        {
            int[] arr1 = new int[m - l + 1];
            int[] arr2 = new int[h - m];
            int[] arr3 = new int[h - l + 1];

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

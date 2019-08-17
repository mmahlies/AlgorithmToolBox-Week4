using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuckSortWithRandom
{
    class Program
    {
        static void Main(string[] args)
        {
          //  int[] dataSet = new int[] { 2, 2, 4, 2 , 2 , 2 ,2,2    }; 
            int intputLenght = int.Parse(Console.ReadLine());
            string[] inputRow = Console.ReadLine().Split(' ');
            int[] dataSet = new int[intputLenght]; 
            for (int i = 0; i < intputLenght; i++)
            {
                dataSet[i] = int.Parse(inputRow[i]);
            }

            DoQuickSort(dataSet, 0, dataSet.Length - 1, isRandom: true);
            foreach (var item in dataSet)
            {
                Console.Write(item + " ");
            }
        }

        private static void DoQuickSort(int[] array, int l, int r, bool isRandom)
        {
            if (l < r)
            {
                Tuple<int, int> pi = Partion(array, l, r, isRandom);
               
                DoQuickSort(array, l, pi.Item1 - 1 -(pi.Item2 -1), isRandom);
                DoQuickSort(array, pi.Item1 + 1, r, isRandom);
            }
        }

        private static Tuple<int,int> Partion(int[] array, int l, int r, bool isRandom)
        {
            int pivot;
            int pivotIndex = 0;
            int pivotCount =1;
            Random d = new Random();
            pivotIndex = d.Next(l, r);
            pivot = array[pivotIndex];

            int smallGroupIndexPlusOne = l;
            if (pivotIndex == smallGroupIndexPlusOne)
            {
                smallGroupIndexPlusOne++;
            }
            for (int i = l; i <= r; i++)
            {
                if (isRandom && i == pivotIndex)
                {
                    continue;
                }   
                if (array[i] <= pivot)
                {
                    Swap(array, smallGroupIndexPlusOne, i);
                    smallGroupIndexPlusOne++;
                    if (array[i] == pivot)
                    {
                        pivotCount++;
                    }
                    else
                    {
                        pivotCount = 1;
                    }
                    if (isRandom && smallGroupIndexPlusOne == pivotIndex)
                    {
                        smallGroupIndexPlusOne++;
                    }
                }
            }

            if (pivotIndex < smallGroupIndexPlusOne)
            {
                Swap(array, smallGroupIndexPlusOne - 1-(pivotCount -1), pivotIndex);
                return new Tuple<int, int>( smallGroupIndexPlusOne - 1 , pivotCount);
            }
            else
            {
                Swap(array, smallGroupIndexPlusOne, pivotIndex);
                return new Tuple<int,int>( smallGroupIndexPlusOne, pivotCount);
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

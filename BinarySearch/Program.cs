using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputRow =  Console.ReadLine().Split(' ');
            int intputLenght = int.Parse(inputRow[0]);
            int[] dataSet = new int[intputLenght];
            for (int i = 0; i < intputLenght; i++)
			{
                dataSet[i] = int.Parse(inputRow[i+1]);
			}

            string[] targetRow = Console.ReadLine().Split(' ');
            int targetLength = int.Parse(targetRow[0]);

            int[] target = new int[targetLength] ;
            for (int i = 0; i < targetLength; i++)
            {
                target[i ] = int.Parse(targetRow[i+1]);
            }

            for (int i = 0; i < target.Length; i++)
            {
                Console.Write(DoBinarySearch(dataSet, 0,dataSet.Length - 1,  target[i]));
                Console.Write(" ");
            }
        }

        private static string DoBinarySearch(int[] array, int l, int r, int target)
        {
            if (l<=r)
            {
                int mid = ((r + l) / 2);
                if (array[mid] == target)
                {
                    return mid.ToString();
                }
                else if (array[mid] > target)
                {
                    return DoBinarySearch(array, l, mid - 1, target);
                }
                else
                {
                    return DoBinarySearch(array, mid + 1, r, target);
                }
            }
            else
            {
                return "-1";
            }
           
        }

   
    }
}

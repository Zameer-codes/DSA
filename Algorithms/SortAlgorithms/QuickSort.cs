using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.SortAlgorithms
{
    public static class QuickSort
    {
        public static void QuickSortAlgorithm()
        {
            int[] inputArray = { 4, 1, 2, 6, 19, 23, 12, 22, 4, 0 };
            QuickSorting(inputArray, 0, inputArray.Length-1);
            for(int i = 0; i < inputArray.Length; i++)Console.WriteLine(inputArray[i]);
        }

        private static void QuickSorting(int[] inputArray, int start, int end)
        {
            if (end <= start) return;
            int pivotIndex = Partition(inputArray, start, end);
            QuickSorting(inputArray, start, pivotIndex - 1);
            QuickSorting(inputArray, pivotIndex + 1, end);
        }

        private static int Partition(int[] inputArray, int start, int end)
        {
            int pivot = inputArray[end];
            int i = start - 1;

            for(int j=start; j<end; j++)
            {
                if(inputArray[j]<pivot)
                {
                    i++;
                    int temp = inputArray[i];
                    inputArray[i] = inputArray[j];
                    inputArray[j] = temp;
                }
            }
            i++;
            int tempPivot = inputArray[end];
            inputArray[end] = inputArray[i];
            inputArray[i] = tempPivot;

            return i;
        }
    }
}

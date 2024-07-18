using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.SortAlgorithms
{
    public static class Test
    {
        public static void ExecuteSort()
        {
            int[] inputArray = { 2, 1, 4, 2, 5, 7 };
            MergeSort(inputArray);
            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.WriteLine(inputArray[i]);
            }
        }
        private static void MergeSort(int[] inputArray)
        {
            int inputLength = inputArray.Length;
            if (inputLength <= 1) return;
            int mid = inputLength / 2;
            int left = mid;
            int right = inputLength - mid;

            int[] leftArray = new int[left];
            int[] rightArray = new int[right];
            int j = 0;
            for (int i = 0; i < inputLength; i++)
            {
                if (i < mid)
                {
                    leftArray[i] = inputArray[i];
                }
                else
                {
                    rightArray[j++] = inputArray[i];
                }
            }
            MergeSort(leftArray);
            MergeSort(rightArray);
            Merging(leftArray, rightArray, inputArray);
        }

        private static void Merging(int[] leftArray, int[] rightArray, int[] inputArray)
        {
            int i = 0;
            int l = 0;
            int r = 0;
            while (l < leftArray.Length && r < rightArray.Length)
            {
                if (leftArray[l] < rightArray[r])
                {
                    inputArray[i++] = leftArray[l++];
                }
                else
                {
                    inputArray[i++] = rightArray[r++];
                }
            }
            while (l < leftArray.Length)
            {
                inputArray[i++] = leftArray[l++];
            }
            while (r < rightArray.Length)
            {
                inputArray[i++] = rightArray[r++];
            }
        }
    }
}

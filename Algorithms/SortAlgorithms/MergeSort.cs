using System;

namespace SortAlgorithms
{
    public class MergeSort
    {
        public void MergeSortingAlgorithm(int[] inputArray)
        {
            MergeSorting(inputArray);
            for (int i = 0; i < inputArray.Length; i++) Console.Write($"{inputArray[i]} ");
        }

        private void MergeSorting(int[] inputArray)
        {
            int inputLength = inputArray.Length;
            if (inputLength <= 1) return; // base case to avoid infinit loop with only one or less elements in an array it means to stop recursion
            int midpoint = inputLength / 2;
            int[] leftArray = new int[midpoint];
            int[] rightArray = new int[inputLength - midpoint];
            int i = 0;
            int j = 0;
            for (; i < inputLength; i++)
            {
                if (i < midpoint)
                {
                    leftArray[i] = inputArray[i];
                }
                else
                {
                    rightArray[j] = inputArray[i];
                    j++;
                }
            }
            MergeSorting(leftArray);
            MergeSorting(rightArray);
            Merge(leftArray, rightArray, inputArray);
        }

        private void Merge(int[] leftArray, int[] rightArray, int[] inputArray){
            int leftSize = inputArray.Length/2;
            int rightSize = inputArray.Length-leftSize;
            int i=0;
            int l=0;
            int r=0;
            while(l<leftSize && r<rightSize){
                if(leftArray[l]<rightArray[r]){
                    inputArray[i]=leftArray[l];
                    l++;
                    i++;
                }
                else{
                    inputArray[i]=rightArray[r];
                    r++;
                    i++;
                }
            }
            while(l<leftSize){
                inputArray[i]=leftArray[l];
                l++;
                i++;
            }
            while(r<rightSize){
                inputArray[i]=rightArray[r];
                r++;
                i++;
            }
        }
    }
}
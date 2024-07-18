using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.SearchAlgorithms
{
    public static class BinarySearch
    {
        public static bool BinarySearchAlgorithm(int[] inputArray, int length, int searchKey)
        {
            Array.Sort(inputArray);
            int low = 0;
            int high = length-1;
            while(low <= high){
                int mid = (low+high)/2;
                if(searchKey == inputArray[mid])
                {
                    return true;
                }
                if(searchKey > inputArray[mid])
                {
                    low = mid + 1;
                }
                if(searchKey < inputArray[mid])
                {
                    high = mid - 1;
                }
            }
            return false;
        }
    }
}

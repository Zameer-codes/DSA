using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndLogicBuilding.Recursion
{
    public static class RecursionProblems
    {
        public static void PrintNameNTimes(int n)
        {
            if (n <= 0) return; //base case
            Console.WriteLine("Tony");
            PrintNameNTimes(n-1);
        }

        public static void PrintNamesNTimesWithoutModifyingState(int i, int n)
        {
            if (i > n) return;
            Console.WriteLine("Tony");
            PrintNamesNTimesWithoutModifyingState(i + 1, n);
        }

        public static void PrintNToOne(int n)
        {
            if (n <= 0) return; //base case to exit
            Console.WriteLine(n);
            PrintNToOne(n - 1);
        }

        public static void PrintOneToN(int i, int n)
        {
            if (i > n) return; //base case to exit
            Console.WriteLine(i);
            PrintOneToN(i+1, n);
        }

        public static void PrintFirstNNaturalNumbersParameterisedWay(int n, int sum = 0)
        {
            if (n <= 0) //base case to exit
            {
                Console.WriteLine($"Sum : {sum}");
                return;
            }
            sum += n;
            PrintFirstNNaturalNumbersParameterisedWay(sum:sum, n:n - 1);
        }

        public static int PrintFirstNNaturalNumbersFunctionalWay(int n)
        {
            if (n == 0)
            {
                return 0; //base case to exit
            }
            return n + PrintFirstNNaturalNumbersFunctionalWay(n - 1);
        }

        public static int FactorialOfANumber(int n)
        {
            if (n == 1)
            {
                return 1; //base case to exit
            }
            return n * FactorialOfANumber(n - 1);
        }

        public static void ReverseArray(int[] arr, int start= 0, int end = -1)
        {
            if (end == -1) end = arr.Length - 1;
            if (start >= end)
            { // base case to exit
                foreach (var n in arr)
                {
                    Console.Write($"{n} ");
                }
                return;
            }
            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
            ReverseArray(arr, start + 1, end - 1);
        }
    }
}

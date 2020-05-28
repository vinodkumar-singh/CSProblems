using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CSProblems
{
    public static class SortingAlogrithm
    {
        public static void Run()
        {
            var arr = new int[] { 4, 3, 9, 6, 1, 5 };
            BubbleSort(arr);
            Console.WriteLine();

            arr = new int[] { 4, 3, 9, 6, 1, 5 };
            InsertionSort(arr);
            Console.WriteLine();

            arr = new int[] { 4, 3, 9, 6, 1, 5 };
            SelectionSort(arr);
            Console.WriteLine();

            arr = new int[] { 4, 3, 9, 6, 1, 5 };
            MergeSort(arr);
            Console.WriteLine();
        }

        public static void BubbleSort(int[] arr)
        {
            Console.WriteLine("Bubble sort");
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        var temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
                arr.Dump();
            }
        }

        public static void InsertionSort(int[] arr)
        {
            Console.WriteLine("Insertion Sort");
            for (int i = 1;i<= arr.Length-1; i++)
            {
                int value = arr[i];
                int index = i;
                while(index > 0 && value < arr[index-1])
                {
                    arr[index] = arr[index - 1];
                    index = index - 1;
                }
                arr[index] = value;
            }
            arr.Dump();
        }

        public static void SelectionSort(int[] arr)
        {
            Console.WriteLine("Selection Sort");
            int iMin = 0;
            int temp = 0;
            for(int i= 0; i<= arr.Length -2; i++)
            {
                iMin = i;
                for(int j= i+1; j<= arr.Length -1; j++)
                {
                    if(arr[j] < arr[iMin])
                    {
                        iMin = j;
                    }
                }
                temp = arr[iMin];
                arr[iMin] = arr[i];
                arr[i] = temp;
            }
            arr.Dump();
        }

        public static void MergeSort(int[] arr)
        {
            Console.WriteLine("Merge Sort");
            MergeSortRecursive(arr);
            arr.Dump();
        }

        public static void MergeSortRecursive(int[] arr)
        {
            if (arr.Length < 2)
                return;
            int mid = arr.Length / 2;
            int[] left = new int[mid];
            int[] right = new int[arr.Length - mid];
            for (int i = 0; i <= mid - 1; i++)
                left[i] = arr[i];
            for (int i = mid; i <= arr.Length-1; i++)
                right[i - mid] = arr[i];
            MergeSortRecursive(left);
            MergeSortRecursive(right);
            MergeArray(left, right, arr);
        }

        private static void MergeArray(int[] left, int[] right, int[] arr)
        {
            int n = left.Length;
            int m = right.Length;
            int i =0, j = 0, k = 0;
            while(i < n && j < m)
            {
                if(left[i] < right[j])
                {
                    arr[k] = left[i];
                    i = i + 1;
                }
                else
                {
                    arr[k] = right[j];
                    j = j + 1;
                }
                k = k + 1;
            }
            while(i < n)
            {
                arr[k] = left[i];
                i = i + 1;
                k = k + 1;
            }
            while(j < m)
            {
                arr[k] = right[j];
                j = j + 1;
                k = k + 1;
            }
        }
    }
}

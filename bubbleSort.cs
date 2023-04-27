using System;

namespace Sorting
{
    class Sort
    {
        static void Main(string[] args)
        {
            int[] arr = { 78, 55, 45, 98, 13 };
            Console.WriteLine("Sorted:");
            int[] sorted = BubbleSort(arr);
            foreach (int p in sorted)
            {
                Console.Write(p + " ");
            }   
        }

        /*
        The pseudocode for bubble sort might look like:
        Repeat n-1 times
            For i from 0 to n–2
                If numbers[i] and numbers[i+1] out of order
                    Swap them
        */

        static int[] BubbleSort(int[] arr)
        {
            int temp;
            for (int j = 0; j <= arr.Length - 2; j++) 
            {
                for (int i = 0; i <= arr.Length - 2; i++) 
                {
                    if (arr[i] > arr[i + 1]) 
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            return arr;
        }
    }
}
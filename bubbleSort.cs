using System;

namespace Sorting
{
    class Sort
    {
        static void Main(string[] args)
        {
            int[] arr = { 78, 55, 45, 98, 13 };
            Console.WriteLine("Unsorted:");            
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            } 
            Console.WriteLine()
            Console.WriteLine("Sorted:");
            int[] sorted = BubbleSort(arr);
            foreach (int i in sorted)
            {
                Console.Write(i + " ");
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
            int temp; // create a container for the next element of the array

            for (int j = 0; j <= arr.Length - 1; j++) 
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
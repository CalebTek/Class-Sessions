/*
5- Write a program and ask the user to enter a series of numbers separated by comma. 
Find the maximum of the numbers and display it on the console. 
For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
*/

using System;
using System.Linq;
using System.Collections.Generic;

namespace Exercise_5
{
    class MaxSeries
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a series of numbers separated by comma e.g 4,5,6...,8: ");
            string numbers = Console.ReadLine();
            string[] nums = numbers.Split(",".ToCharArray());
            var number = new List<int>();
            foreach (var item in nums)
            {
                number.Add(Convert.ToInt32(item));
            }
            Console.WriteLine($"Max: {number.Max()}");

        }
    }
}
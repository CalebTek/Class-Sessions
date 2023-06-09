/*
1- Write a program and ask the user to enter a few numbers separated by a hyphen. 
Work out if the numbers are consecutive. 
For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: 
"Consecutive"; otherwise, display "Not Consecutive".
*/


using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_1
{
    class ConsecutiveNumbers
    {
        static void Main(string[] args)
        {
            string msg = "";
            Console.Write($"Enter numbers in the following format => 4-5-3-2-5-2-6-4-9: ");
            string numbers = Console.ReadLine();
            var numSplit = numbers.Split('-').Select(int.Parse).ToArray();
            for (int i = 0; i < numSplit.Length-1; i++)
            {
                var front = numSplit[i];
                var end = numSplit[i + 1];
                if (Math.Abs(front - end) != 1)
                {
                    msg = "Not Consecutive";
                    break;
                } else
                {
                    msg = "Consecutive";
                    continue;
                }                
            }
            Console.WriteLine(msg);
        }
    }
}
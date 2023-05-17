/*
2- Write a program and ask the user to enter a few numbers separated by a hyphen. 
If the user simply presses Enter, without supplying an input, exit immediately; 
otherwise, check to see if there are duplicates. 
If so, display "Duplicate" on the console.
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_2
{
    class Diplicates
    {
        static void Main(string[] args)
        {
            string msg = "";
            Console.Write($"Enter numbers in the following format => 4-5-3-2-5-2-6-4-9: ");
            string numbers = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(numbers))
            {
                Environment.Exit(0);
            }
            var numSplit = numbers.Split('-').Select(int.Parse).ToArray();
            var numSeen = new bool[numSplit.Max()+numbers.Length];
            for (int i = 0; i < numSplit.Length - 1; i++)
            {

                if (numSeen[numSplit[i]])
                {
                    msg = "Duplicate";
                    break;
                } else
                {
                    msg = "No Duplicate";
                }
                numSeen[numSplit[i]] = true;
                
            }
            Console.WriteLine(msg);
        }
    }
}
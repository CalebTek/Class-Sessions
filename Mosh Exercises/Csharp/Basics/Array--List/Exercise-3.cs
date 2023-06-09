/*
3- Write a program and ask the user to enter 5 numbers. 
If a number has been previously entered, display an error message and ask the user to re-try. 
Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
*/

using System;
using System.Collections.Generic;

namespace Exercise_3
{
    class UniqueNumbers
    {
        static void Main(string[] args)
        {
            var numberList = new List<int>();
            int start = 0, end = 5;
            do
            {
                Console.Write("Enter a number: ");
                var input = Console.ReadLine();
                int number;
                while (!int.TryParse(input, out number) || numberList.Contains(number))
                {
                    Console.Write("Invalid Input, please re-try: ");
                    input = Console.ReadLine();
                }
                start++;
                numberList.Add(number);
            } while (start < end);
            numberList.Sort();
            foreach (var number in numberList)
            {
                Console.Write($"{number} ");
            }

        }

        
    }
}
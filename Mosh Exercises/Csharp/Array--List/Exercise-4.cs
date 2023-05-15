/*
4- Write a program and ask the user to continuously enter a number or type "Quit" to exit. 
The list of numbers may include duplicates. Display the unique numbers that the user has entered.
*/


using System;
using System.Collections.Generic;

namespace Exercise_4
{
    class UniqueNumbers
    {
        static void Main(string[] args)
        {
            var numberList = new List<int>();
            do
            {
                Console.Write("Enter a number: ");
                var input = Console.ReadLine();
                if (input.ToUpper() == "QUIT")
                {
                    break;
                }
                int number;
                while (!int.TryParse(input, out number))
                {
                    Console.Write("Invalid Input, please re-try: ");
                    input = Console.ReadLine();
                }
                if (!numberList.Contains(number))
                {
                    numberList.Add(number);
                }
            } while (true);
            foreach (var number in numberList)
            {
                Console.Write($"{number} ");
            }

        }


    }
}
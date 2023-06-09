/*
2- Write a program which takes two numbers from the console and displays the maximum of the two.
*/
using System;

namespace Exercise_2
{
    class MaximumNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number");
            int secondNumber = int.Parse(Console.ReadLine());
            int max = firstNumber > secondNumber ? firstNumber : secondNumber;
            Console.WriteLine($"maximum number is {max}");
        }
    }
}
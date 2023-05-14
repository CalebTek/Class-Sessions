/*
1- Write a program and ask the user to enter a number. The number should be between 1 to 10. 
If the user enters a valid number, display "Valid" on the console. Otherwise, display "Invalid". 
(This logic is used a lot in applications where values entered into input boxes need to be validated.)
*/
using System;

namespace Exercise_1
{
    class ValidNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 and 10");
            int number = int.Parse(Console.ReadLine());
            string message = number > 0 && number < 11 ? "Valid" : "Invalid";
            Console.WriteLine($"{number} is {message}");
        }
    }
}
/*
2- Write a program and continuously ask the user to enter a number or "ok" to exit. 
Calculate the sum of all the previously entered numbers and display it on the console.
*/

using System;

namespace Exercise_2
{
    class ContinuousLoop
    {
        static void Main(string[] args)
        {
            int sum = 0;
            string breaker = "OK";
            do
            {
                
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();
                if (input.ToUpper() == breaker)
                {
                    break;
                }
                sum += int.Parse(input);
            } while (true);
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
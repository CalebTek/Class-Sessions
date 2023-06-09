/*
1- Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. 
Display the count on the console.
*/

using System;

namespace Exercise_1
{
    class DivisibleByTwo
    {
        static void Main(string[] args)
        {
            int counter = 0;
            for (int i = 3; i <=100; i+=3)
            {
                //Console.Write($"{i} ");
                counter++;
            }
            Console.WriteLine($"Total Count: {counter}");
        }
    }
}
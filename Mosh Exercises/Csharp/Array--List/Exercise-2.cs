/*
2- Write a program and ask the user to enter their name. 
Use an array to reverse the name and then store the result in a new string. 
Display the reversed name on the console.
*/


using System;
using System.Collections.Generic;

namespace Exercise_2
{
    class ReverseArray
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            var name = Console.ReadLine();
            var arrayName = name.ToCharArray();
            Array.Reverse(arrayName);
            var reverseName = String.Join("", arrayName);
            Console.WriteLine($"Reversed {name}: {reverseName}");
        }
    }
}
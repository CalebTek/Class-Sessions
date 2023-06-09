/*
5- Write a program and ask the user to enter an English word. 
Count the number of vowels (a, e, o, u, i) in the word. 
So, if the user enters "inadequate", the program should display 6 on the console.
*/

using System;
using System.Linq;
namespace Exercise_5
{
    class vowels
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an English word: ");
            var word = Console.ReadLine();
            var vowelCount = word.Count(x => x == 'a' || x == 'e' || x == 'i' || x == 'o' || x == 'u');
            Console.WriteLine($"Vowels in {word} = {vowelCount}");
        }
    }
}
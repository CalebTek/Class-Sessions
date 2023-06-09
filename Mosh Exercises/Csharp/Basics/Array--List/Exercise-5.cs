/*
5- Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). 
If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; 
otherwise, display the 3 smallest numbers in the list.
*/


using System;
using System.Linq;
using System.Collections.Generic;

namespace Exercise_5
{
    class CheckList
    {
        static void Main(string[] args)
        {
            /* Console.Write("Enter a series of numbers separated by comma e.g 4,5,6...,8: ");
            string numbers = Console.ReadLine();
            var number = new List<int>();
            do
            {
                string[] nums = numbers.Split(",".ToCharArray());
                foreach (var item in nums)
                {
                    number.Add(Convert.ToInt32(item));
                }
                if ((number.Count() < 3))
                {
                    Console.Write("Invalid list, Please Re-try: ");
                    numbers = Console.ReadLine();
                    number.Clear();
                    nums = numbers.Split(",".ToCharArray());
                    foreach (var item in nums)
                    {
                        number.Add(Convert.ToInt32(item));
                    }
                    if (number.Count() < 3)
                    {
                        var selectedList = number.Take(3).ToList();
                        foreach (var item in selectedList)
                        {
                            Console.Write($"{item} ");
                        }
                    }else
                    {
                        foreach (var item in number)
                        {
                            Console.Write($"{item} ");
                        }
                    }
                }
            } while (true);
            /* foreach (var item in number)
            {
                Console.WriteLine($"{item} ");
            } 
            
 */
        }
    }
}
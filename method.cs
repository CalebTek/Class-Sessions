using System;
using System.Collections.Generic;

namespace SimpleFunction
{
    class method
    {
        static void  Main(string[] args)
        {
            /*
            Program that print even number within a given range of number
            */
            Console.Write("How many numbers do you want to print: ");
            int length;

            try
            {
                length = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.Exception)
            {
                Console.WriteLine("Input is wrong, Please enter a number");
                throw;
            }

            Console.WriteLine(EvenNumbers(length));

        }
        
        // Even Numbers
        // Using modulo operator
        //Console.WriteLine($"Print {length} even number(s) using modulo operator ");

        static List EvenNumbers(int length)
        {
            List<int> numbers = new List<int>();
            int counter = 0;
            for (int i = 1; i < length*3; i++)
            {
                if (i%2 == 0)
                {
                    numbers.Add(i);
                    counter ++;
                    if (counter >= length)
                    {
                        break;
                    }
                }
                
            }

            // Print all elements in the list to the console
            /* for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            } */
            return numbers;
        }

    }
}

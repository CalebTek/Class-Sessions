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

            Console.WriteLine(EvenNumbersList(length));
            Console.WriteLine(EvenNumbersArray(length));

        }
        
        // Even Numbers
        // Using modulo operator
        //Console.WriteLine($"Print {length} even number(s) using modulo operator ");

        //static int[] EvenNumbers(int len)
        static List<int> EvenNumbersList(int len)
        {
            List<int> numbers = new List<int>();
            //int arrSize = len;
            //int[] numArr = new int[arrSize];
            int counter = 0;
            for (int i = 1; i < len*3; i++)
            {
                if (i%2 == 0)
                {
                    numbers.Add(i);
                    //numArr[i-1] = i;
                    counter ++;
                    if (counter >= len)
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
            //return numArr;
        }

        /// <summary>
        /// Create List of Even numbers
        /// </summary>
        /// <param name ="Size">The Size of the List</param>
        /// <returns> The List of Even numbers in a class list</returns>
        
        static int[] EvenNumbersArray(int len)
        //static List<int> EvenNumbersArray(int len)
        {
            //List<int> numbers = new List<int>();
            int arrSize = len;
            int[] numArr = new int[arrSize];
            //int counter = 0;
            for (int i = 0; i < len; i++)
            {  
                numArr[i] = (i+1) *2 ;
            }

            // Print all elements in the list to the console
            /* for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            } */
            //return numbers;
            return numArr;
        }

    }
}

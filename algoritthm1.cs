using System;

namespace Algorithm
{
    class DigitalRoots
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a non-negative integer: ")
            int numbers = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(DigitalRoot())
        }

        static int DigitalRoot(int num)
        {
            if (num < 10)
            {
                return num;
            }
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num = Math.Floor(num / 10); 
            }
            return DigitalRoot(num);
        }
    }
}

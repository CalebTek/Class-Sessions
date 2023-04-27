using System;

namespace Algorithm
{
    class DigitalRoots
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a non-negative integer: ");
            int numbers = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(DigitalRoot(numbers));
        }

        static int DigitalRoot(int num)
        {
            if (num < 10)
            {
                return num;
            }else{
                int sum = 0;

            while (num > 0)
            {
                sum += num % 10;
                num = num / 10; 
            }
            return DigitalRoot(sum);
            }
            
        }

        static int Recursion(int num)
        {
            int sum = 0;
            string str = Convert.ToString(num);
            while(str.Length > 1)
            {
                
                for (int i = 0; i < str.Length; i++){
                    sum += (int)str[i];
                }
            } return sum;
        }
    }
}

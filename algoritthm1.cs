using System;
using System.Collections.Generic;

namespace Algorithm
{
    class DigitalRoots
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a non-negative integer: ");
            int numbers = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(DigitalRoot(numbers));
            //Console.WriteLine(Recursion(numbers));
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

        /* static int Recursion(int num) // assume input '99'
        {
            int sum = 0, result; 
            string str = Convert.ToString(num); // '99' => "99"
            while(str.Length > 1) // "99".Length = 2 , "18".Length = 2, "9".Length = 1
            //for (int j = 0; j < str.Length; j++)
            {
                for (int i = 0; i < str.Length; i++){
                    sum += Convert.ToInt32(str[i]);
                    //1.while:
                    // i=0(9): sum = 9, i=1(9): sum = 18 
                    //2.while:
                    // i=0(1): sum = 1, i=1(8): sum = 9 
                }
                str = Convert.ToString(sum);
                // 1.while: str = "18"
                // 2. while str = "9"
            } 
            result = Convert.ToInt32(str); // result = '9'
            return Recursion(result);
        } */

        static int Recursion(int num)
        {
            //int numbers = Convert.ToInt32(num);
            while (num >= 9)
            {
                List<int> splits = new List<int>();
                string numStr = Convert.ToString(num);
                int length = numStr.Length;
                for (int i = 0; i < length; i++)
                {
                    splits.Add(numStr[i]);
                }
                int sum = 0;
                foreach (int i in splits)
                {
                    sum += i;
                }
                num = sum;
            }
            return Recursion(num);
        }
    }
}

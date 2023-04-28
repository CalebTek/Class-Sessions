using System;

namespace Binary
{
    class BaseConvert
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Int32ToString(1234,2));
            Console.WriteLine(CountBits(1234));
            Console.WriteLine(CountBits2(1234));
        }

        public static string Int32ToString(int value, int toBase)
        {
            string result = string.Empty;
            do
            {
                result = "0123456789ABCDEF"[value % toBase] + result;
                value /= toBase;
            }
            while (value > 0);

            

            return result;
        }

        public static int CountBits(int n)
        {
            int count = 0;
            while (n != 0)
            {
                count += n & 1;
                n >>= 1;
            }
         return count;
        }

        public static int CountBits2(int n)
        {
            int count = 0;
            while (n > 0)
            {
                count += n % 2;
                n /= 2;
            }
         return count;
        }
    }
}
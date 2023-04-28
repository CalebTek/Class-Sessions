using System;

namespace Binary
{
    class BaseConvert
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Int32ToString(12345,2));
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
    }
}
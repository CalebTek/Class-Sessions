using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Practice_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var withdrawal = Withdraw(440);
            foreach (var item in withdrawal)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            var roman = RomanToInt("III");
            Console.WriteLine(roman);
        }

        public static List<int> Withdraw(int amount)
        {
            // Check how many 100 dollar we can get in the amount
            int _100Bills = amount / 100;
            amount %= 100; // remainder of the division
                           // Check how many 50 dollar we can get in the amount
            int _50Bills = amount / 50;
            amount %= 50; // remainder of the division
                          // Check how many 20 dollar we can get in the amount
            int _20Bills = amount / 20;
            var withdrawal = new List<int> { _100Bills, _50Bills, _20Bills };
            return withdrawal;
        }
        public static int RomanToInt(string s)
        {
            Dictionary<char, int> romanValues = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

            int result = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (i < s.Length - 1 && romanValues[s[i]] < romanValues[s[i + 1]])
                {
                    result -= romanValues[s[i]];
                }
                else
                {
                    result += romanValues[s[i]];
                }
            }

            return result;
        }
    }
}

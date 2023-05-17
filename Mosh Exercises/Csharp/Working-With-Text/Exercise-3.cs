/*
3- Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). 
A valid time should be between 00:00 and 23:59. 
If the time is valid, display "Ok"; otherwise, display "Invalid Time". 
If the user doesn't provide any values, consider it as invalid time.
*/

using System;
using System.Linq;

namespace Exercise_3
{
    class DateTimeFormat
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a time value in the 24-hour time format e.g. 19:00 : ");
            var dateString = Console.ReadLine();
            var _hour00 = DateTime.Parse("00:00").TimeOfDay;
            var _hour23 = DateTime.Parse("23:00").TimeOfDay;
            DateTime date;
            if (DateTime.TryParse(dateString, out date) && date.TimeOfDay >= _hour00 && date.TimeOfDay <= _hour23)
            {
                Console.WriteLine("Valid");
            } else
            {
                Console.WriteLine("Invalid");
            }
        }
            
    }
}
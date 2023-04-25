using System;

namespace SimpleFunctio
{
    class method
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

// Even Numbers
// Using modulo operator
//Console.WriteLine($"Print {length} even number(s) using modulo operator ");

Static int EvenNumbers(int length)
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
    return numbers;
}

    }
}

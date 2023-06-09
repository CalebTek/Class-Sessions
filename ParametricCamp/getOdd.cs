using System;

int number = 10, sum = 0;
for (int i = 1; i < number; i++)
{
    if (i % 3 == 0 || i % 5 == 0)
    {
        Console.WriteLine(i);
        sum = sum + i;
    }
}
Console.WriteLine(sum);
using System;

Console.WriteLine("Prime numbers: ");
for (int i = 2; i < 100; i++)
{
    bool isPrime = true;
    for (int j = 2; j < i; j++)
    {
        if (i % j == 0)
        {
            isPrime = false;
            break;
        }
    }
    if (isPrime == true)
    {
        Console.WriteLine(i);
    }
}
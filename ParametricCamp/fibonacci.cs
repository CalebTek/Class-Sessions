using System;

Console.WriteLine("Fibonacci Sequence: ");
int n0 = 1, n1 = 1;
Console.WriteLine(n0);
Console.WriteLine(n1);
for (int i = 0; i < 10; i++)
{
    int sum = n0 + n1;
    Console.WriteLine(sum);

    n0 = n1;
    n1 = sum;
}
Console.WriteLine();
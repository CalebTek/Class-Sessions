using System;
using System.Collections.Generic;

int num = 12345;
List<int> splits = new List<int>();
string numStr = Convert.ToString(num);
Console.WriteLine($"Conversion of {num} to string is {numStr}");
int length = numStr.Length;
Console.WriteLine($"Length is {length}");
foreach (int i in numStr)
{
    Console.Write($"{i} ");
}
for (int i = 0; i < length; i++)
{
    splits.Add(numStr[i]);
}
//int sum = 0;
foreach (int i in splits)
{
    //sum += i;
    Console.Write(i);
}
//num = sum;

//Console.WriteLine(num);
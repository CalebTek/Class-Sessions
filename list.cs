using System;
using System.Collections.Generic;

// An empty list of integer numbers
List<int> numbers = new List<int>();
//var numbers = new List<int>();

int elements = 25;

// Add elements
for (int i = 0; i < elements; i++)
{
    numbers.Add(10*i);
}

// Print all elements in the list to the console
for (int i = 0; i < numbers.Count; i++)
{
    Console.WriteLine(numbers[i]);
}

// manually override values on a list
Console.WriteLine($"{numbers[0]} is the first element in the list before");
numbers[0] = 23;
Console.WriteLine($"{numbers[0]} is now the first element in the list after the element override");
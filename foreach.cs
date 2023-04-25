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
/* for (int i = 0; i < numbers.Count; i++)
{
    Console.WriteLine(numbers[i]);
} */

// Print all elements in the list to the console using foreach
foreach (int num in numbers)
{
    Console.WriteLine(num);
}


// manually override values on a list
/* Console.WriteLine($"{numbers[0]} is the first element in the list before");
numbers[0] = 23;
Console.WriteLine($"{numbers[0]} is now the first element in the list after the element override"); */



// Create an array of data
int arrSize = 25;
int[] numArr = new int[arrSize];

// add new element in the array
for (int i = 0; i < numArr.Length; i++)
{
    numArr[i] = 5 * i;
}

// Print element in the array
/* for (int i = 0; i < numArr.Length; i++)
{
    Console.WriteLine(numArr[i]);
} */

// Print element in the array using foreach
foreach (var num in numArr)
{
    Console.WriteLine(num);
}
using System;

// Create an array of data
int arrSize = 25;
int[] numArr = new int[arrSize];

// add new element in the array
for (int i = 0; i < numArr.Length; i++)
{
    numArr[i] = 5 * i;
}

// Print element in the array
for (int i = 0; i < numArr.Length; i++)
{
    Console.WriteLine(numArr[i]);
}
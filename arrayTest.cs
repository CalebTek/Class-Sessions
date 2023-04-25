using System;

int arrSize = 10;
int[] numArr = new int[arrSize];
int counter = 0;
for (int i = 1; i < arrSize*3; i++)
{
    if (i%2 == 0)
    {
        //numbers.Add(i);
        numArr[i-1] = i;
        counter ++;
        if (counter >= arrSize)
        {
            break;
        }
    }
    
}

Console.WriteLine(numArr);
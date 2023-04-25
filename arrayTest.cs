using System;

int arrSize = len;
int[] numArr = new int[arrSize];
int counter = 0;
for (int i = 1; i < len*3; i++)
{
    if (i%2 == 0)
    {
        //numbers.Add(i);
        numArr[i-1] = i;
        counter ++;
        if (counter >= len)
        {
            break;
        }
    }
    
}

Console.WriteLine(numArr);
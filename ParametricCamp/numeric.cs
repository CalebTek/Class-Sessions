using System;

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


// Even Numbers
// Using modulo operator
Console.WriteLine($"Print {length} even number(s) using modulo operator ");
int counter = 0 ;
for (int i = 1; i < length*3; i++)
{
    if (i%2 == 0)
    {
        Console.WriteLine(i);
        counter ++;
        if (counter >= length)
        {
            break;
        }
    }
       
}


// Using for loop increment
Console.WriteLine($"Print {length} even number(s) using for loop increment operator ");
counter = 0 ;
for (int i = 2; i < length*3; i+=2)
{
    Console.WriteLine(i);
    counter ++;
    if (counter >= length)
        {
            break;
        }
}

// Using for loop multiplication trick
Console.WriteLine($"Print {length} even number(s) using for loop multiplication trick ");
counter = 0 ;
for (int i = 1; i < length*3; i++)
{
    Console.WriteLine(i*2);
    counter ++;
    if (counter >= length)
        {
            break;
        }
}

// Odd Numbers
// Using modulo operator
Console.WriteLine($"Print {length} odd number(s) using modulo operator ");
counter = 0 ;
for (int i = 1; i < length*3; i++)
{
    if (i%2 == 1)
    {
        Console.WriteLine(i);
        counter ++;
        if (counter >= length)
        {
            break;
        }
    }
       
}


// Using for loop increment
Console.WriteLine($"Print {length} odd number(s) using for loop increment operator ");
counter = 0 ;
for (int i = 1; i < length*3; i+=2)
{
    Console.WriteLine(i);
    counter ++;
    if (counter >= length)
        {
            break;
        }
}

// Using for loop multiplication trick
Console.WriteLine($"Print {length} odd number(s) using for loop multiplication trick ");
counter = 0 ;
for (int i = 0; i < length*3; i++)
{
    Console.WriteLine(i*2 + 1);
    counter ++;
    if (counter >= length)
        {
            break;
        }
}






 /*
    switch (i%2)
    {
        case 0:
            Console.WriteLine(i);
            counter ++;
            if (counter == length)
            {
                break;
            }
            break;
    }
    */
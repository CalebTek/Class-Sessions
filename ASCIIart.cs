using System;

Console.WriteLine("Let's create some cool ASCII art!");
Console.WriteLine();

int width = 50, height = 20;

Console.WriteLine("SOLID RECTANGLE");
for (int i = 0; i < height; i++)
{
    for (int j = 0; j < width; j++)
    {
        Console.Write("#");
    }
    Console.WriteLine();
}


Console.WriteLine("BORDER RECTANGLE");
int borderWidth = 2;
for (int i = 0; i < height; i++)
{
    for (int j = 0; j < width; j++)
    {
        if (i < borderWidth || i > height -1 - borderWidth 
            || j < borderWidth || j > height - 1 - borderWidth)
            {
               Console.Write("#"); 
            } else
            {
                Console.Write(" ");
            }
    }
    Console.WriteLine();
}
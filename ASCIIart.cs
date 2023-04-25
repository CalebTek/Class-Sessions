using System;

Console.WriteLine("Let's create some cool ASCII art!");
Console.WriteLine();

int width = 50, height = 20;

for (int i = 0; i < height; i++)
{
    for (int j = 0; j < width; j++)
    {
        Console.Write("#");
    }
    Console.WriteLine();
}
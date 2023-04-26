using System;

Console.WriteLine("Let's create some cool ASCII art!");
Console.WriteLine();

int width = 30, height = 10;

Console.WriteLine("SOLID RECTANGLE");
for (int i = 0; i < height; i++)
{
    for (int j = 0; j < width; j++)
    {
        Console.Write("█");
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("BORDER RECTANGLE");
int borderWidth = 2;
for (int i = 0; i < height; i++)
{
    for (int j = 0; j < width; j++)
    {
        if (i < borderWidth || i > height -1 - borderWidth 
            || j < borderWidth || j > width - 1 - borderWidth)
            {
               Console.Write("█"); 
            } else
            {
                Console.Write(" ");
            }
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("CHECKER PATTERN");
//int borderWidth = 2;
for (int i = 0; i < height; i++)
{
    for (int j = 0; j < width; j++)
    {
        if ((i+j) % 2 == 0)
            {
               Console.Write("█"); 
            } else
            {
                Console.Write(" ");
            }
    }
    Console.WriteLine();
}


Console.WriteLine();
Console.WriteLine("PYRAMID");
int  pyramidWidth = height * 2 - 1;
int centerColumn = height - 1;
for (int i = 0; i < height; i++)
{
    for (int j = 0; j < pyramidWidth; j++)
    {
        if (j >= centerColumn - i && j <=  centerColumn + i)
            {
               Console.Write("█"); 
            } else
            {
                Console.Write(" ");
            }
    }
    Console.WriteLine();
}


Console.WriteLine();
Console.WriteLine("CIRCLE");
double centerX = width / 2.0;
double centerY = height / 2.0;
double radius = 0.0;
if (height < width)
{
    radius = 0.5 * height;
} else
{
    radius = 0.5 * width;
}
for (int i = 0; i < height; i++)
{
    for (int j = 0; j < width; j++)
    {
        double dy = i - centerY;
        double dx = j - centerX;
        double d = Math.Sqrt(dx * dx + dy * dy);
        if (d < radius)
            {
               Console.Write("█"); 
            } else
            {
                Console.Write(".");
            }
    }
    Console.WriteLine();
}
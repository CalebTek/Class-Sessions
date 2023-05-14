/*
3- Write a program and ask the user to enter the width and height of an image. 
Then tell if the image is landscape or portrait.
*/

using System;

namespace Exercise_3
{
    class Orientation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the image height");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the image width");
            int width = int.Parse(Console.ReadLine());
            string orientation = height < width ? "Landscape" : "Portrait";
            Console.WriteLine($"Image Orientation is {orientation}");
        }
    }
}
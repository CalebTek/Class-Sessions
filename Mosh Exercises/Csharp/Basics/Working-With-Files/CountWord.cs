using System;
using System.IO;

class Program
{
    static int CountWords(string filename)
    {
        try
        {
            string content = File.ReadAllText(filename);
            string[] words = content.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"File '{filename}' not found.");
            return 0;
        }
    }

    static void Main()
    {
        string filePath = "sample.txt";
        int wordCount = CountWords(filePath);
        Console.WriteLine($"Number of words in '{filePath}': {wordCount}");
    }
}

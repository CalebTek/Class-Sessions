using System;
using System.IO;
using System.Linq;

class Program
{
    static string FindLongestWord(string filename)
    {
        try
        {
            string content = File.ReadAllText(filename);
            string[] words = content.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            string longestWord = words.OrderByDescending(w => w.Length).FirstOrDefault();
            return longestWord;
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"File '{filename}' not found.");
            return string.Empty;
        }
    }

    static void Main()
    {
        string filePath = "sample.txt";
        string longestWord = FindLongestWord(filePath);
        Console.WriteLine($"Longest word in '{filePath}': {longestWord}");
    }
}

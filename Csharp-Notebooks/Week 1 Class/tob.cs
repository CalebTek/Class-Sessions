using System;
namespace Testing
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type help to show options");
            Console.Write("> ");
            string inputLine = Console.ReadLine().Trim();
            while (!(inputLine == "") && !(inputLine == "exit"))
            {
                if (inputLine.ToLower() == "add")
                {
                    Console.WriteLine("Oh you type add");
                    //break;
                } else if (inputLine.ToLower() == "help")
                {
                    Console.WriteLine("oh you type help");
                    //break;
                } else
                {
                    Console.WriteLine("Invalid input");   
                    //break;
                }
                Console.Write("> ");
                inputLine = Console.ReadLine();
                Console.Clear();
            }

        }
    }
}
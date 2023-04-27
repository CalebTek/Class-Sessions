using System;

namespace testVoid
{
    class VoidAction
    {
        static void Main(string[] args)
        {
            string name = "C.E.O Odeyemi";
            Log($"{name}");
        }

        static void Log(string str)
        {
            Console.WriteLine(str);
        }
    }
}
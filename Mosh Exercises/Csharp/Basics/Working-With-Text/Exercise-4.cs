/*
4- Write a program and ask the user to enter a few words separated by a space. 
Use the words to create a variable name with PascalCase. 
For example, if the user types: "number of students", display "NumberOfStudents". 
Make sure that the program is not dependent on the input. 
So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".
*/

using System;
using System.Text;
using System.Linq;
namespace Exercise_4
{
    class PascalCasePhrase
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a few words separated by a space: ");
            var phrase = Console.ReadLine();
            var phraseArray = phrase.ToLower().Split();
            var titleCase = phraseArray.Select(i => Char.ToUpper(i[0]) + i.Substring(1));
            var pascalCase = String.Join("", titleCase);
            //var pascalCase = String.Join(" ", phrase.ToLower().Split().Select(i => Char.ToUpper(i[0]) + i.Substring(1))).Replace(" ","");
            Console.WriteLine(pascalCase);
        }

    }
}
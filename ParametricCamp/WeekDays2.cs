using System;

Console.WriteLine("Enter a number 1 and 7");
int day = int.Parse(Console.ReadLine());
string weekDays;
switch (day){
    case 1: 
    weekDays = "Monday";
    break;
    case 2:
    weekDays = "Tuesday";
    break;
    case 3:
    weekDays = "Wednesday";
    break;
    case 4:
    weekDays = "Thursday";
    break;
    case 5:
    weekDays = "Friday";
    break;
    case 6:
    weekDays = "Saturday";
    break;
    case 7:
    weekDays = "Sunday";
    break;
    default:
    weekDays = "No day";
    break;
}

Console.WriteLine($"{weekDays} is the day {day} of the week");
Console.ReadLine();
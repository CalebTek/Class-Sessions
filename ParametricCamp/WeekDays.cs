using System;

Console.WriteLine("Enter a number between 1 and 7");
int day = int.Parse(Console.ReadLine());
string weekDays;
if(day==1)
{
    weekDays="Monday" ;
} else if(day==2)
{
    weekDays="Tuesday" ;
} else if(day==3)
{
    weekDays="Wednesday";
} else if(day==4)
    {
    weekDays="Thursday" ;
} else if(day==5)
{
    weekDays="Friday";
} else if(day==6)
    {
    weekDays="Saturday" ;
}else if(day==7)
{
    weekDays = "Sumday";
} else
{
    weekDays = "No Day";
}
    
Console.WriteLine($"{weekDays} is day {day} of the Week");
Console.Read();
/*
4- Your job is to write a program for a speed camera. 
For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic. 
Write a program that asks the user to enter the speed limit. 
Once set, the program asks for the speed of a car. 
If the user enters a value less than the speed limit, program should display Ok on the console. 
If the value is above the speed limit, the program should calculate the number of demerit points. 
For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console. 
If the number of demerit points is above 12, the program should display License Suspended.
*/

using System;

namespace Exercise_4
{
    class SpeedLimit
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the speed limit: ");
            int speedLimit = int.Parse(Console.ReadLine());
            Console.Write("Enter the car speed: ");
            int carSpeed = int.Parse(Console.ReadLine());
            /* string message = carSpeed <= speedLimit ? "Speed OK" : 
                                carSpeed > (speedLimit) && carSpeed <= (speedLimit + 5) ? "1 demerit points incurred" :
                                carSpeed > (speedLimit + 5) && carSpeed <= (speedLimit + 10) ? "2 demerit points incurred" :
                                carSpeed > (speedLimit + 10) && carSpeed <= (speedLimit + 15) ? "3 demerit points incurred" :
                                carSpeed > (speedLimit + 15) && carSpeed <= (speedLimit + 20) ? "4 demerit points incurred" :
                                carSpeed > (speedLimit + 20) && carSpeed <= (speedLimit + 25) ? "5 demerit points incurred" :
                                carSpeed > (speedLimit + 25) && carSpeed <= (speedLimit + 30) ? "6 demerit points incurred" :
                                carSpeed > (speedLimit + 30) && carSpeed <= (speedLimit + 35) ? "7 demerit points incurred" :
                                carSpeed > (speedLimit + 35) && carSpeed <= (speedLimit + 40) ? "8 demerit points incurred" :
                                carSpeed > (speedLimit + 40) && carSpeed <= (speedLimit + 45) ? "9 demerit points incurred" :
                                carSpeed > (speedLimit + 45) && carSpeed <= (speedLimit + 50) ? "10 demerit points incurred" :
                                carSpeed > (speedLimit + 50) && carSpeed <= (speedLimit + 55) ? "11 demerit points incurred" :
                                carSpeed > (speedLimit + 55) && carSpeed <= (speedLimit + 60) ? "12 demerit points incurred" : "License Suspended"; */
            int speedPerDemerit = 5;
            var demeritPoint = (carSpeed-speedLimit)/speedPerDemerit;
            string message = carSpeed <= speedLimit ? "Speed OK" : demeritPoint > 12 ? "License Suspended" : $"{demeritPoint} demerit points incurred";
                                
            Console.WriteLine($"{carSpeed}Km/hr: {message}");
        }
    }
}
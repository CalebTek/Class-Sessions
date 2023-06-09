using System;

Console.WriteLine("enter either red,yellow or black");
string color = (Console.ReadLine());
/*switch(color){
    case "red": 
    Console.WriteLine("Case No 1");
    break;
    case "yellow":
    Console.WriteLine("Case No 2");
    break;
    case "black":
    Console.WriteLine("Case No 3");
    break;
    default:
    Console.WriteLine("Unknown");
    break;
}
*/
string message;
switch(color){
    case "red": 
    message ="Case No 1";
    break;
    case "yellow":
    message = "Case No 2";
    break;
    case "black":
    message = "Case No 3";
    break;
    default:
    message = "Unknown";
    break;
}

Console.WriteLine(message);
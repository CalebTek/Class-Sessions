double number = 4;
// Data types
// int, string, bool, double, float, decimal, char
double sum = number + number;
double divide = 6 / number;
double remainder = 6 % number;
//remainder
//divide
char myChar = 'D';
// collection types
// Array, List, Dictionary, Tuple

// Operators
// Arithmetic, Assignment, Relational, Logical
int num1 = 10;
num1 += 10;
num1 -= 5;
num1 %= 5;
//num /
//number < 10
//num1

int num5 = 10, num2 = 15, num3 = 89, num4 = 98;
// equals to
//num5 == num3
// not equals to
//num5 != num4
//num5 != 9
// greater than
//num4 > num5
// greater than or equal to
//num4 >= num5
// less than
//num4 < num5
// less than or equal to
//num4 <= num5

// Logical
// AND (&&), OR (||)
// && Operator
// T - True, F - false
// T && T = T, T && F = F, F && F = F, F && T = F
// || Operator
// T || T = T, T || F = T, F || F = F, F || T = T

//false && num4 == num5 
//39 > num4 && num4 < 45
//0 < num3 && num3 < 40
//false || num4 == num5 
//39 > num4 || num4 < 45
//0 < num3 || num3 < 40

// voting system base on age
int age = 15;
//age > 17


//## If Statment
/* if (condition)
{
    // block of codes
} */

age = 67;
if (age < 17)
{
    Console.WriteLine("You cannot Vote");
}

//## if esle statment
/* if (condition)
{
    // block of code
}
else if (condition)
{

} */

age = 78;
if (age < 17)
{
    Console.WriteLine("You cannot vote");
}
else if (age > 17)
{
    Console.WriteLine("You can vote");
}

age = 89;
if (age < 17)
{
    Console.WriteLine("You cannot vote");
    Console.WriteLine($"You are {age} years old");
    Console.WriteLine("Please come back when you are 17 years");
}
else
{
    Console.WriteLine("You can vote");
}

/* Absolute value
Given an integer, write a method that returns its absolute value.
Expected input and output
AbsoluteValue(6832) → 6832
AbsoluteValue(-392) → 392 */

int num = -98;
if (num < 0)
{
    int abs = num * -1;
    Console.WriteLine(abs);
}
else
{
    //int abs = num;
    Console.WriteLine(num);
}

/* 
public int Abs(int number)
{
    if (number < 0)
    {
        return number * -1;
    }
    return number;
}

Abs(-23)
 */
// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("Do you wish to multiply, add, divide, subtract, or find the square root?");

string answer = Console.ReadLine();
// multiplication
if(answer == "multiply")
{
Console.WriteLine("Type a number in here.");

int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Number typed: " + number);

Console.WriteLine("Type another number in here.");

int number2 = Convert.ToInt32(Console.ReadLine());

int sum = number * number2;
Console.WriteLine("Answer: " + sum);
}
// addition
if(answer == "add")
{
Console.WriteLine("Type a number in here.");

int number3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Number typed: " + number3);

Console.WriteLine("Type another number in here.");

int number4 = Convert.ToInt32(Console.ReadLine());

int sum2 = number3 + number4;
Console.WriteLine("Answer: " + sum2);
}
// division
if(answer == "divide")
{
Console.WriteLine("Type a number in here.");

int number5 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Number typed: " + number5);

Console.WriteLine("Type another number in here.");

int number6 = Convert.ToInt32(Console.ReadLine());

int sum3 = number5 / number6;
Console.WriteLine("Answer: " + sum3);
}
// subtraction
if(answer == "subtract")
{
Console.WriteLine("Type a number in here.");

int number7 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Number typed: " + number7);

Console.WriteLine("Type another number in here.");

int number8 = Convert.ToInt32(Console.ReadLine());

int sum4 = number7 - number8;
Console.WriteLine("Answer: " + sum4);
}
// finding square root
if(answer == "square root")
{
Console.WriteLine("Type a number in here.");

int number9 = Convert.ToInt32(Console.ReadLine());
// took me way too long to figure out you didnt need a sum, code is probably bad but it works
Console.WriteLine("Answer: " + (Math.Sqrt(number9)));
}


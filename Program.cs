// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Formats.Asn1;
using System.Runtime.InteropServices;

Console.WriteLine("The objective of this game is to guess what number I generate between 1-100.");
Console.WriteLine("Press any key to continue.");

Console.ReadKey(true);

Random rand = new Random();
int randomNumber = rand.Next(1, 101);

int attempts = 0; // initial amount of attempts

int maxAttempts = 5; // maximum amount of attempts

bool guessedCorrectly = false;

while (!guessedCorrectly && attempts < maxAttempts)
{
Console.WriteLine("What is your guess?");

int answer = Convert.ToInt32(Console.ReadLine());

attempts++; // helps to make the attempt variable change apparently


if (answer < randomNumber) // answer is too low
    {
        Console.WriteLine("That guess is too low! Try again");
    }
    else if (answer > randomNumber) // answer is too high
    {
        Console.WriteLine("That guess is too high! Try again");
    }
else // answer is right
{
    Console.WriteLine("You win! Congratulations!");
    guessedCorrectly = true; 
}
}

if (!guessedCorrectly && attempts >= maxAttempts) // exceeding maximum amount of attempts
{
    Console.WriteLine("You ran out of attempts. The correct number was: " + randomNumber + ". " + "You lose!");
}

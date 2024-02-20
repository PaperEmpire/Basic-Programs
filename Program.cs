// See https://aka.ms/new-console-template for more information

// Ask for user's name
using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Hello! What is your name?");

string userName = Console.ReadLine();

Console.WriteLine("Hello " + userName +"!");
// Ask for opponent's name
Console.WriteLine("Who is your opponent?");

string opponentName = Console.ReadLine();

Console.WriteLine("Your opponent is " + opponentName +"!");

Console.WriteLine("Press any key to generate a random number for " + userName + ".");

Console.ReadKey(true);
Random rand = new Random();
int randomNumber = rand.Next();

Console.WriteLine("Random number generated for " + userName +": " + randomNumber );

Console.WriteLine("Press any key to generate a random number for " + opponentName + ".");

Console.ReadKey(true);
Random rand2 = new Random();
int randomNumber2 = rand2.Next();

Console.WriteLine("Random number generated for " + opponentName +": " + randomNumber2 );

int highest = Math.Max(randomNumber, randomNumber2);

if (randomNumber < randomNumber2)
{
    Console.WriteLine(opponentName + " wins!");
}

if (randomNumber2 < randomNumber)
{
    Console.WriteLine(userName + " wins!");
}

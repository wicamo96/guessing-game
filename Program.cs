using System;

int SecretNumber = 42;

Console.Write("Guess a secret number: ");
string input = Console.ReadLine();

while (input == "")
{
    Console.Write("Guess a secret number: ");
    input = Console.ReadLine();
}

if (int.Parse(input) == SecretNumber)
{
    Console.WriteLine("You got it!!");
}
else
{
    Console.WriteLine("Not quite!");
}
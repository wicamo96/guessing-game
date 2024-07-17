using System;

int SecretNumber = 42;

Console.Write("Guess a secret number: ");
string input = Console.ReadLine();

for (int i = 0; i < 3; i++)
{
    if (int.Parse(input) == SecretNumber)
    {
        Console.WriteLine("You got it!!");
        break;
    }
    else
    {
        Console.WriteLine("Not quite! Guess again");
        input = Console.ReadLine();
    }
}
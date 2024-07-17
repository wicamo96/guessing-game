using System;

Random random = new Random();
int SecretNumber = random.Next(1, 101);

Console.Write("Guess a secret number (guess 1/4): ");
string input = Console.ReadLine();

for (int i = 0; i < 3; i++)
{
    if (int.Parse(input) == SecretNumber)
    {
        break;
    }
    else
    {
        Console.WriteLine($"Not quite! Guess again (guess {i + 2}/4)");
        input = Console.ReadLine();
    }
}

if (int.Parse(input) == SecretNumber)
{
    Console.WriteLine("You got it!!");
}

if (int.Parse(input) != SecretNumber)
{
    Console.WriteLine("Better luck next time bucko!");
}
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
        if (int.Parse(input) > SecretNumber)
        {
            Console.WriteLine($"Too high! Guess again (guess {i + 2}/4)");
            input = Console.ReadLine();
        }
        else
        {
            Console.WriteLine($"Too low! Guess again (guess {i + 2}/4)");
            input = Console.ReadLine();
        }
    }
}

if (int.Parse(input) == SecretNumber)
{
    Console.WriteLine("You got it!!");
}

if (int.Parse(input) != SecretNumber)
{
    Console.WriteLine($"It was {SecretNumber}, better luck next time bucko!");
}
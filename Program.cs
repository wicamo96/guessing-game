using System;

Random random = new Random();
int SecretNumber = random.Next(1, 101);

Console.Write("Guess a secret number game; Select difficulty (easy/medium/hard): ");
string input = Console.ReadLine();


switch (input)
{
    case "easy":
        GuessingGame(8);
        break;
    case "medium":
        GuessingGame(6);
        break;
    case "hard":
        GuessingGame(4);
        break;
}
void GuessingGame (int integer)
{
    Console.Write($"Guess the secret number (guess 1/{integer}): ");
    string guess = Console.ReadLine();
    for (int i = 0; i < integer - 1; i++)
    {
        if (int.Parse(guess) == SecretNumber)
        {
            break;
        }
        else
        {
            if (int.Parse(guess) > SecretNumber)
            {
                Console.WriteLine($"Too high! Guess again (guess {i + 2}/{integer})");
                guess = Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"Too low! Guess again (guess {i + 2}/{integer})");
                guess = Console.ReadLine();
            }
        }
    }

    if (int.Parse(guess) == SecretNumber)
    {
        Console.WriteLine("You got it!!");
    }

    if (int.Parse(guess) != SecretNumber)
    {
        Console.WriteLine($"It was {SecretNumber}, better luck next time bucko!");
    }
}

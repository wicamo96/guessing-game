using System;

Console.Write("Guess a secret number: ");
string input = Console.ReadLine();

while (input == "")
{
    Console.Write("Guess a secret number: ");
    input = Console.ReadLine();
}

Console.WriteLine($"{int.Parse(input)}");

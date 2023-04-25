using System;

class Program
{
    static void Main(string[] args)
    {
        // Asks for user input for first name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        // Asks for user input for last name
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // Prints input in sentance "Your name is Burton, Scott Burton."
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}
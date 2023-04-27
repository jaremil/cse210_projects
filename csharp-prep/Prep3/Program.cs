using System;

class Program
{
    static void Main(string[] args)
    {
        Random generator = new Random();
        int secret_number = generator.Next(1,3);

        Console.Write("What is your guess? ");
        string guess_str = Console.ReadLine();
        int guess = int.Parse (guess_str);

        bool countinue = true;

        while (true) {
            if (guess > secret_number) {
                
                Console.WriteLine($"{guess} is too high! Guess again");
                bool countinue = true;

            } else if (guess < secret_number){
                
                Console.WriteLine($"{guess} is too low! Guess again");
                bool countinue = true;

            } else if (guess == secret_number) {
                
                Console.WriteLine($"You're right! The number was {guess}");
                bool countinue = false;

            } 
        }
    }
}
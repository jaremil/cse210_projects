using System;

class Program
{
    static void Main(string[] args)
    {
        var numbers = new List<int>();

        while (true) {
            Console.Write("Please enter a number (enter 0 to stop): ");

            int number = int.Parse(Console.ReadLine());
            
            if (number == 0) {
                break;
            }

            numbers.Add(number);
        
        }

        foreach (var num in numbers) {
            int number_added = 0;

            

        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("What is your grade percentage? ");
        // puting grade percentage into a string
        string grade_str = Console.ReadLine();
        // converting string into an integer
        int grade = int.Parse (grade_str);

        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else if (grade < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"{letter} - {grade}");

        if (grade <= 70)
        {
            Console.WriteLine("With this grade percentage, you have failed the course. We encourage you to try again.");
        }
        else
        {
            Console.WriteLine("Congradulations, with this grade you have passed this course!");
        }
    }
}
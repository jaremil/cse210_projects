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

        if (grade >= 90)
        {
            Console.WriteLine($"A - {grade}%");
            if (grade <= 70)
            {
                Console.WriteLine("With this grade percentage, you have failed the course. We encourage you to try again.");
            }
            else
            {
                Console.WriteLine("Congradulations, with this grade you have passed this course!");
            }
        }
        else if (grade >= 80)
        {
            Console.WriteLine($"B - {grade}%");
            if (grade <= 70)
            {
                Console.WriteLine("With this grade percentage, you have failed the course. We encourage you to try again.");
            }
            else
            {
                Console.WriteLine("Congradulations, with this grade you have passed this course!");
            }
            }
        else if (grade >= 70)
        {
            Console.WriteLine($"C - {grade}%");
            if (grade <= 70)
            {
                Console.WriteLine("With this grade percentage, you have failed the course. We encourage you to try again.");
            }
            else
            {
                Console.WriteLine("Congradulations, with this grade you have passed this course!");
            }
        }
        else if (grade >= 60)
        {
            Console.WriteLine($"D - {grade}%");
            if (grade <= 70)
            {
                Console.WriteLine("With this grade percentage, you have failed the course. We encourage you to try again.");
            }
            else
            {
                Console.WriteLine("Congradulations, with this grade you have passed this course!");
            }
        }
        else if (grade < 60)
        {
            Console.WriteLine($"F - {grade}%");
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
}
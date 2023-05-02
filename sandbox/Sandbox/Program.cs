using System;

class Program
{
    static void Main(string[] args)
    {
        var personOne = new Person("Layne", "Moseley");
        var personTwo = new Person("David", "Hasselhoff");

        personOne.Talk();
        personTwo.Talk();
    }
}


// class means classification
// public = can be used in other places
// void = doesn't return a value
class Person {

    // attributes / properties

    string firstName;
    string lastName;

    // constructor 

    public Person(string fn, string ln) {
        firstName = fn;
        lastName = ln;
    }

    //behaviors
    public void Breathe() {
        Console.WriteLine("Breathing");
    }

    public void Walk() {
        Console.WriteLine("Walking");
    }

    public void Talk(){
        Console.WriteLine($"Hello, my name is {FullName()}.");
    }

    public string FullName() {

        return $"{firstName} {lastName}";

        // This code is another option to do the same thing
        // public void FullName() {
        // string full = String.Concat($"{firstName} {lastName}");
        // return full;
        //}

    }
}
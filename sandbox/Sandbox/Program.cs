using System;

class Program
{
    static void Main(string[] args)
    {
        var personOne = new Person("Layne", "Moseley");
        var personTwo = new Person("David", "Hasselhoff");
        List<string> myList = new List<string>() {
            "Jade Miller",
            "Jane Doe"
        };

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

class Program
{
    static void Main(string[] args)
    {
        Job job_one = new Job();
        job_one.jobTitle = "";
        job_one.company = "";
        job_one.startYear = ;
        job_one.endYear = ;

        Job job_two = new Job();
        job_two.jobTitle = "";
        job_two.company = "";
        job_two.startYear = ;
        job_two.endYear = ;

        Resume officalResume = new Resume();
        officalResume.name = "";
        Resume.job_career.Add(job_one);
        Resume.job_career.Add(job_two);

        officalResume.Display();
    }
}

public class Job
{
    string company;
     public Job(string jt) {
        company = jt;
    }

   string jobTitle;
     public Job(string jtt) {
        jobTitle = jtt;
    }

   string startYear;
     public Job(int sy) {
        startYear = sy;
    }

   int endYear;
     public Job(int ey) {
        endYear = ey;
    }
}

public class Resume
{
    public string _name;

    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}

class Program{

static void Main(string[] args)
{
    var savings = new Account();
    savings.Deposit(500);
    savings.Deposit(1000);
}
    public class Account{
        // private means that it can only be used inside of this class. If it is tried to be used outside 
        // of the class then an error stating that it is not accessible because of it's level
        private List<int> _transactions = new List<int>();

        public void Deposit(int amount){
            _transactions.Add(amount);
        }

        public int Balance(){
            var balance = 0;
            foreach (var transaction in _transactions){
                balance += transaction;
            }

            return balance;
        }
    }
}
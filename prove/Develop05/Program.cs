using System;

class Program
{
    // atributes
    List<string> _menu;
    List<string> _goals;

    // constructor
    public Program(List<string> menu, List<string> goals){
        _menu = menu;
        _goals = goals;
    }

    // methods
    // static void Main(string[] args)
    static void Main(string[] args)
    {
        var simpleGoalDescription = new SimpleGoal();

        string userInput = "0";
        while (userInput != "6")
        {
            Console.Clear();
            Console.WriteLine("Please choose a mindfullness activity by inputing the corresponding number");
            Console.WriteLine("\n1. create new goal");
            Console.WriteLine("2. list goals");
            Console.WriteLine("3. save goals");
            Console.WriteLine("4. load goals");
            Console.WriteLine("5. record event");
            Console.WriteLine("6. quit");
            Console.Write("\nEnter number here: ");

            userInput = Console.ReadLine();

            // Goal.GetInteger();

            if (userInput == "1") {

                string input = "0";
                while (input != "6"){
                    Console.Clear();
                    Console.WriteLine("1. simple goal");
                    Console.WriteLine("2. eternal goal");
                    Console.WriteLine("3. checklist goal");
                    Console.Write("\nWhich type of goal would you like it create?: ");

                    input = Console.ReadLine();

                    if (input == "1") {
                        SimpleGoal();
                    }
                    else if (input == "2") {
                        EternalGoal();
                    }
                    else if (input == "3") {
                        ChecklistGoal();
                    }
                }
                    Console.Clear();
            }
            else if (userInput == "2") {
                
            }
            else if (userInput == "3") {
                // Save();
            }
            else if (userInput == "4") {
                // Load();
            }
            else if (userInput == "5") {
                
            }
            Console.Clear();
        };
    }

    // public string Save(){}
    public void Save(){
  
    }

    // public void Load(){
    public void Load(){

    }
}

// parent class
class Goal {
    //attributes
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _truefalse;

    // constructors
    public Goal(string name, string description, int points, bool truefalse){
        _name = name;
        _description = description;
        _points = points;
        _truefalse = truefalse;
    }

    //methods
    // public string RecordEvent(){
    public void RecordEvent(){
      
    }

    // public string IsComplete(){
    public void IsComplete(){
        
    }

    public static int GetInteger(){
        Console.Clear();

        while (true) {
            Console.Write("How many points will this goal be worth? ");
            var input = Console.ReadLine();

            try {
            var value = int.Parse(input);
            return value;
            } catch(Exception) {
                Console.Clear();
                Console.WriteLine("Incorrect format, please insert an integer.");
            }
        }
    }
}

//child class
class SimpleGoal: Goal{
    public SimpleGoal (string name, string description, int points, bool truefalse): base(name, description, points, truefalse){
    }
}    

// child class
class EternalGoal: Goal{
        public EternalGoal (string name, string description, int points, bool truefalse): base(name, description, points, truefalse){

        }
}

// child class
class ChecklistGoal: Goal{
    //attribute
    int _bonus;
    int _timesDetermined;
    int _timesComplete;

    //constructor
    public ChecklistGoal(int bonus, int timesDetermined, int timesComplete, string name, string description, int points, bool truefalse): base(name, description, points, truefalse){
        _bonus = bonus;
        _timesDetermined = timesDetermined;
        _timesComplete = timesComplete;
    }
}

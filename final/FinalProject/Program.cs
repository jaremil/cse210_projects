using System;

class Program {
    
    static void Main() {

        DecisionMaking decisionMaking = new DecisionMaking();

        string startMessageDecisionMaking = "Introduction, Desciption";

        // Tests.Loading(5);
        Console.Clear();
        Console.WriteLine("Welcome! This program will ask you a series of questionnaires to determine if you think more logically or creatively.");
        Console.WriteLine("");
        Console.WriteLine("Please Note that these questions provide a simplified way to assess thinking tendencies and individuals may not strickly fit into one category. However, they can provide some insight into whether a person leans more towards logical or creative thinking.");
     
        List<string> history = new List<string>();

        string userInput = "";
        while (userInput != "7") {
            Console.WriteLine("1-6 7 stop");
            userInput = Console.ReadLine();
            if (userInput == "1"){
                if (!history.Contains("1")){
                    history.Add("1");
                    Console.WriteLine(startMessageDecisionMaking);
                    decisionMaking.doActivity();
                }
                else{
                    Console.WriteLine("This test has already been finished.");
                }
            }
            if (userInput == "2"){
                // Console.WriteLine(startmessageHabits);
            }
            else if (userInput == "3"){
                // Console.WriteLine(startmessagePreferences);
            }
            else if (userInput == "4"){
                // Console.WriteLine(startmessageStrengths);
            }
            else if (userInput == "5"){
                // Console.WriteLine(startMessageTrivia);
            }
            else if (userInput == "6"){
                // Console.WriteLine(startMessageEmotions);
            }
        }
    }
}

class Guess {
    private bool _guess;
        Guess (bool guess){
            _guess = guess;
        }
}

class Answer {
    string _answers;
    int _points;

    public Answer (string answers, int points){
        _points = points;
        _answers = answers;
    }
}

class Question {
    string _question;

    public Question (string question){
        _question = question;
    }
}

class Tests {

    string _description;
    List<string> _loading;

    public Tests(string description, List<string> loading){
        _description = description;
        _loading = loading;
    }

    public static void Loading(int duration) {

        List<string> animations = new List<string> {
            "Loading -",
            "Loading \\",
            "Loading |",
            "Loading /",
        };

        var startTime = DateTime.Now;
        var endTime = startTime.AddSeconds(duration);

        int animationIndex = 0;

        while(DateTime.Now < endTime) {
            string frame = animations[animationIndex];
            
            Console.Clear();
            Console.Write(frame);
            Thread.Sleep(225);
            Console.Write("\b \b");

            animationIndex++;
            if (animationIndex >= animations.Count) {
                animationIndex = 0;
            }
        }
    }
}

class DecisionMaking {

    private int score = 0;
    private List<string> _decisions = new List<string>(){
        "Question 1",
        "2",
        "3",
        "4"
    };

    public DecisionMaking (){
    
    }

    public int returnScore(){
        return score;
    }
    public void doActivity(){

        foreach (string decision in _decisions){
            Console.WriteLine(decision);
    
            Console.WriteLine("1 Yes 2 It's Possible 3 Eh, I don't think so 4 No way it does");
            score += int.Parse(Console.ReadLine()) * 10;
        }
    }
}

class Habits {
    private List<Answer> _habits;

    public Habits (List<Answer> habits){
        _habits = habits;
    }
    List<Answer> emotions = new List<Answer> {
        new Answer("question here", 10),
        new Answer("question here", 20),
        new Answer("question here", 30),
        new Answer("question here", 40)
    };
}

class Preferences{
    private List<Answer> _preferences;

    public Preferences (List<Answer> preferences){
        _preferences = preferences;
    }
    List<Answer> emotions = new List<Answer> {
        new Answer("question here", 10),
        new Answer("question here", 20),
        new Answer("question here", 30),
        new Answer("question here", 40)
    };
}

class Strengths {
    private List<Answer> _strengths;

    public Strengths (List<Answer> strengths){
        _strengths = strengths;
    }
    List<Answer> emotions = new List<Answer> {
        new Answer("question here", 10),
        new Answer("question here", 20),
        new Answer("question here", 30),
        new Answer("question here", 40)
    };
}

class Trivia {
    private List<Answer> _trivia;

    public Trivia (List<Answer> trivia){
        _trivia = trivia;
    }
    List<Answer> emotions = new List<Answer> {
        new Answer("question here", 10),
        new Answer("question here", 20),
        new Answer("question here", 30),
        new Answer("question here", 40)
    };
}

class Emotions {
    private List<Answer> _emotion;

    public Emotions (List<Answer> emotion){
        _emotion = emotion;
    }
    List<Answer> emotions = new List<Answer> {
        new Answer("question here", 10),
        new Answer("question here", 20),
        new Answer("question here", 30),
        new Answer("question here", 40)
    };
}
using System;

class Program {
    
    static void Main() {

        DecisionMaking decisionMaking = new DecisionMaking();

        string startMessageDecisionMaking = "Introduction, Desciption";
        string startmessageHabits = "Introduction, Desciption";
        string startMessagePreferences = "Introduction, Desciption";
        string startMessageStrengths = "Introduction, Desciption";
        string startMessageTrivia = "Introduction, Desciption";
        string startMessageEmotions = "Introduction, Desciption";

        Tests.Loading(5);
        Console.Clear();
        Console.WriteLine("Welcome! This program will ask you a series of questionnaires to determine if you think more logically or creatively.");
        Console.WriteLine("Please Note that these questions provide a simplified way to assess thinking tendencies and individuals may not strickly fit into one category. However, they can provide some insight into whether a person leans more towards logical or creative thinking.");
     
        List<string> history = new List<string>();

        string userInput = "";
        while (userInput != "7") {
            Console.WriteLine("Please take each of these questionnaires to recieve your results. 1 Decision Making Questionnaire 2 Habits Questionnaire 3 Preferences Questionnaire 4 Strengths Questionnaire 5 Trivia Questionnaire 6 Emotions Questionnaire If you wish to end the program early enter 7");
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
                Console.WriteLine(startmessageHabits);
            }
            else if (userInput == "3"){
                Console.WriteLine(startMessagePreferences);
            }
            else if (userInput == "4"){
                Console.WriteLine(startMessageStrengths);
            }
            else if (userInput == "5"){
                Console.WriteLine(startMessageTrivia);
            }
            else if (userInput == "6"){
                Console.WriteLine(startMessageEmotions);
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
        "Question1 1 answer 2 answer 3 answer 4 answer",
        "Question2 1 answer 2 answer 3 answer 4 answer",
        "Question3 1 answer 2 answer 3 answer 4 answer",
        "Question4 1 answer 2 answer 3 answer 4 answer"
    };

    public int returnScore(){
        return score;
    }
    public void doActivity(){

        foreach (string decision in _decisions){
            Console.WriteLine(decision);
            score += int.Parse(Console.ReadLine()) * 10;
        }
    }
}

class Habits {
    private int score = 0;
    private List<string> _decisions = new List<string>(){
        "Question1 1 answer 2 answer 3 answer 4 answer",
        "Question2 1 answer 2 answer 3 answer 4 answer",
        "Question3 1 answer 2 answer 3 answer 4 answer",
        "Question4 1 answer 2 answer 3 answer 4 answer"
    };

    public int returnScore(){
        return score;
    }
    public void doActivity(){

        foreach (string decision in _decisions){
            Console.WriteLine(decision);
            score += int.Parse(Console.ReadLine()) * 10;
        }
    }
}

class Preferences{
    private int score = 0;
    private List<string> _decisions = new List<string>(){
        "Question1 1 answer 2 answer 3 answer 4 answer",
        "Question2 1 answer 2 answer 3 answer 4 answer",
        "Question3 1 answer 2 answer 3 answer 4 answer",
        "Question4 1 answer 2 answer 3 answer 4 answer"
    };

    public int returnScore(){
        return score;
    }
    public void doActivity(){

        foreach (string decision in _decisions){
            Console.WriteLine(decision);
            score += int.Parse(Console.ReadLine()) * 10;
        }
    }
}

class Strengths {
    private int score = 0;
    private List<string> _decisions = new List<string>(){
        "Question1 1 answer 2 answer 3 answer 4 answer",
        "Question2 1 answer 2 answer 3 answer 4 answer",
        "Question3 1 answer 2 answer 3 answer 4 answer",
        "Question4 1 answer 2 answer 3 answer 4 answer"
    };

    public int returnScore(){
        return score;
    }
    public void doActivity(){

        foreach (string decision in _decisions){
            Console.WriteLine(decision);
            score += int.Parse(Console.ReadLine()) * 10;
        }
    }
}

class Trivia {
    private int score = 0;
    private List<string> _decisions = new List<string>(){
        "Question1 1 answer 2 answer 3 answer 4 answer",
        "Question2 1 answer 2 answer 3 answer 4 answer",
        "Question3 1 answer 2 answer 3 answer 4 answer",
        "Question4 1 answer 2 answer 3 answer 4 answer"
    };

    public int returnScore(){
        return score;
    }
    public void doActivity(){

        foreach (string decision in _decisions){
            Console.WriteLine(decision);
            score += int.Parse(Console.ReadLine()) * 10;
        }
    }
}

class Emotions {
    private int score = 0;
    private List<string> _decisions = new List<string>(){
        "Question1 1 answer 2 answer 3 answer 4 answer",
        "Question2 1 answer 2 answer 3 answer 4 answer",
        "Question3 1 answer 2 answer 3 answer 4 answer",
        "Question4 1 answer 2 answer 3 answer 4 answer"
    };

    public int returnScore(){
        return score;
    }
    public void doActivity(){

        foreach (string decision in _decisions){
            Console.WriteLine(decision);
            score += int.Parse(Console.ReadLine()) * 10;
        }
    }
}
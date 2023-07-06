using System;

// I have six result percentages that I would like to add up into one percentage. How would I do that?

class Program {
    static private List<string> _startMenu;
    static private bool _guess;
    static private int _testData;
    
    static void Main(string[] args) {

        var startmessageDecisionMaking = new StartMessage("Introduction", "Description");
        var startmessageHabits = new StartMessage("Introduction", "Description");
        var startmessagePreferences = new StartMessage("Introduction", "Description");
        var startmessageStrengths = new StartMessage("Introduction", "Description");
        var startmessageTrivia = new StartMessage("Introduction", "Description");
        var startmessageEmotions = new StartMessage("Introduction", "Description");
    }
}

class StartMessage {
    protected string _introduction;
    protected string _description;

    public StartMessage(string introduction, string description){
        _introduction = introduction;
    }
}

class Tests {

    StartMessage _startMessage;
    string _description;
    List<string> _loading;

    public Tests(StartMessage startMessage, string description, List<string> loading){
        _startMessage = startMessage;
        _description = description;
        _loading = loading;
    }

    private void Results() {

    }

    public static void Countdown(int duration) {
        List<string> animations = new List<string> {
            "7",
            "6",
            "5",
            "4",
            "3",
            "2",
            "1",
        };

        var startTime = DateTime.Now;
        var endTime = startTime.AddSeconds(duration);

        int animationIndex = 0;

        while(DateTime.Now < endTime) {
            string frame = animations[animationIndex];
            Console.Clear();
            Console.Write(frame);
            Thread.Sleep(1000);

            animationIndex++;
            if (animationIndex >= animations.Count) {
                animationIndex = 0;
            }
        }
    }
}

class Question {
    string _question;
    int _points;

    public Question (string question, int points){
        _points = points;
        _question = question;
    }
}

class DecisionMaking {
    private List<Question> _decisions;

    public DecisionMaking (List<Question> decisons){
        _decisions = decisons;
    }
    List<Question> emotions = new List<Question> {
        new Question("question here", 10),
        new Question("question here", 20),
        new Question("question here", 30),
        new Question("question here", 40)
    };
}

class Habits {
    private List<Question> _habits;

    public Habits (List<Question> habits){
        _habits = habits;
    }
    List<Question> emotions = new List<Question> {
        new Question("question here", 10),
        new Question("question here", 20),
        new Question("question here", 30),
        new Question("question here", 40)
    };
}

class Preferences{
    private List<Question> _preferences;

    public Preferences (List<Question> preferences){
        _preferences = preferences;
    }
    List<Question> emotions = new List<Question> {
        new Question("question here", 10),
        new Question("question here", 20),
        new Question("question here", 30),
        new Question("question here", 40)
    };
}

class Strengths {
    private List<Question> _strengths;

    public Strengths (List<Question> strengths){
        _strengths = strengths;
    }
    List<Question> emotions = new List<Question> {
        new Question("question here", 10),
        new Question("question here", 20),
        new Question("question here", 30),
        new Question("question here", 40)
    };
}

class Trivia {
    private List<Question> _trivia;

    public Trivia (List<Question> trivia){
        _trivia = trivia;
    }
    List<Question> emotions = new List<Question> {
        new Question("question here", 10),
        new Question("question here", 20),
        new Question("question here", 30),
        new Question("question here", 40)
    };
}

class Emotions {
    private List<Question> _emotions;

    public Emotions (List<Question> emotions){
        _emotions = emotions;
    }
    List<Question> emotions = new List<Question> {
        new Question("question here", 10),
        new Question("question here", 20),
        new Question("question here", 30),
        new Question("question here", 40)
    };
}
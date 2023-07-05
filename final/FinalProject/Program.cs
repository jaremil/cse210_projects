using System;

class Program {
    private List<string> _startMenu;
    private bool _guess;
    private int _testData;

    public Program (List<string> startMenu, bool guess, int testData){
        _startMenu = startMenu;
        _guess = guess;
        _testData = testData;
    }
    
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

// parent class
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

class DecisionMaking {
    private List<string> _decisions;

    public DecisionMaking (List<string> decisons){
        _decisions = decisons;
    }
}

class Habits {
    private List<string> _habits;

    public Habits (List<string> habits){
        _habits = habits;
    }
}

class Preferences{
    private List<string> _preferences;

    public Preferences (List<string> preferences){
        _preferences = preferences;
    }
}

class Strengths {
    private List<string> _strengths;

    public Strengths (List<string> strengths){
        _strengths = strengths;
    }
}

class Trivia {
    private List<string> _trivia;

    public Trivia (List<string> trivia){
        _trivia = trivia;
    }
}

class Emotions {
    private List<string> _emotions;

    public Emotions (List<string> emotions){
        _emotions = emotions;
    }
}
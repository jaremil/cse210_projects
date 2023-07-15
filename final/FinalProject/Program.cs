using System;

class Program {
    static void Main() {

        DecisionMaking decisionMaking = new DecisionMaking();
        Habits habits = new Habits();
        Preferences preferences = new Preferences();
        Strengths strengths = new Strengths();
        Trivia trivia = new Trivia();
        Emotions emotions = new Emotions();

        string startMessageDecisionMaking = "Decision Making Questionnaire";
        string startmessageHabits = "Habits Questionnaire";
        string startMessagePreferences = "Preferences Questionnaire";
        string startMessageStrengths = "Strengths and Weaknesses Questionnaire";
        string startMessageTrivia = "Trivia Questionnaire";
        string startMessageEmotions = "Emotions Questionnaire";

        Console.Clear();
        Console.WriteLine("Welcome! This program will give you a series of questionnaires to determine if you think more logically or creatively.");

        Console.WriteLine("\nBefore we start, do you think that you think more creatively or logically?");
        string guess = Console.ReadLine();

        Console.Clear();
     
        List<string> history = new List<string>();

        string userInput = "";
        while (userInput != "7") {
            Console.WriteLine("\nPlease take each of these questionnaires once before receiving your results: \n1 Decision Making Questionnaire \n2 Habits Questionnaire \n3 Preferences Questionnaire \n4 Strengths Questionnaire \n5 Trivia Questionnaire \n6 Emotions Questionnaire \n7 See results");
            userInput = Console.ReadLine();

            if (userInput == "1"){
                Console.Clear();
                if (!history.Contains("1")){
                    history.Add("1");
                    Loading.LoadingAnimation(3);
                    Console.Clear();
                    Console.WriteLine(startMessageDecisionMaking);
                    decisionMaking.doActivity();
                }
                else{
                    Console.WriteLine("This test has already been finished.");
                }
            }
            if (userInput == "2"){
                Console.Clear();
                if (!history.Contains("2")){
                    history.Add("2");
                    Loading.LoadingAnimation(3);
                    Console.Clear();
                    Console.WriteLine(startmessageHabits);
                    habits.doActivity();
                }
                else{
                    Console.WriteLine("This test has already been finished.");
                }
            }
            else if (userInput == "3"){
                Console.Clear();
                if (!history.Contains("3")){
                    history.Add("3");
                    Loading.LoadingAnimation(3);
                    Console.Clear();
                    Console.WriteLine(startMessagePreferences);
                    preferences.doActivity();
                }
                else{
                    Console.WriteLine("This test has already been finished.");
                }
            }
            else if (userInput == "4"){
             Console.Clear();
                if (!history.Contains("4")){
                    history.Add("4");
                    Loading.LoadingAnimation(3);
                    Console.Clear();
                    Console.WriteLine(startMessageStrengths);
                    strengths.doActivity();
                }
                else{
                    Console.WriteLine("This test has already been finished.");
                }
            }
            else if (userInput == "5"){
             Console.Clear();
                if (!history.Contains("5")){
                    history.Add("5");
                    Loading.LoadingAnimation(3);
                    Console.Clear();
                    Console.WriteLine(startMessageTrivia);
                    trivia.doActivity();
                }
                else{
                    Console.WriteLine("This test has already been finished.");
                }
            }
            else if (userInput == "6"){
             Console.Clear();
                if (!history.Contains("6")){
                    history.Add("6");
                    Loading.LoadingAnimation(3);
                    Console.Clear();
                    Console.WriteLine(startMessageEmotions);
                    emotions.doActivity();
                }
                else{
                    Console.WriteLine("This test has already been finished.");
                }
            }
        }

            Console.WriteLine($"{emotions.GetCreativePercent()}");

            Console.Clear();
            Console.WriteLine($"Your guess was: {guess} \n Your results were: \nDesion Making {decisionMaking.GetCreativePercent()}% creative {decisionMaking.GetLogicalPercent()}% logical \nHabits {habits.GetCreativePercent()}% creative {habits.GetLogicalPercent()}% logical \nPreferences {preferences.GetCreativePercent()}% creative {preferences.GetLogicalPercent()}% logical \nStrengths and Weaknesses {strengths.GetCreativePercent()}% creative {strengths.GetLogicalPercent()}% logical \nTrivia {trivia.GetCreativePercent()}% creative {trivia.GetLogicalPercent()}% logical Emotions {emotions.GetCreativePercent()}% creative {emotions.GetLogicalPercent()}% logical");
    }
}

class Loading {
    public static void LoadingAnimation(int duration) {

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

class Quiz {
    protected int creativePercent = 0;
    protected int logicPercent = 0; 

    public int GetCreativePercent(){
        return creativePercent;
    }
        public int GetLogicalPercent(){
        return logicPercent;
    }

    protected virtual List<string> questions { get; set; }

    public void doActivity(){
        Console.WriteLine(questions.Count);

        foreach (string question in questions){
            Console.WriteLine(question);
            string answer = Console.ReadLine();

            if (answer == "1"){
                creativePercent += 25;
            }
            else if (answer == "2"){
                creativePercent += 25;
            }
            else if (answer == "3"){
                logicPercent +=  25;
            }
            else if (answer == "4"){
                logicPercent += 25;
            }
        }
    }   
}

class DecisionMaking: Quiz {
    protected List<string> _questions = new List<string>(){
        "\nWhen problem solving, do you focus on established guidelines and facts or do explore unconventional approaches and possibilities? \n1 I prefer to explore unconventional approaches and possibilities \n2 I focus more on finding new approaches but still keep the basic guidelines \n3 I rely on rules and facts to find new possibilities \n4 I perfer to focus on established rules and facts",
        "Is it easier for you to make a decision when given guidelines or when given freedom to think outside of the box? \n1 It is easier to make decisions when thinking outside the box \n2 It is easier to make decisions when given freedom to think outside the box with some guidelines \n3 It is easier to make decisions when given guidelines with some freedom to think outside the box \n4 It is easier to make decisions when given guidelines",
        "How comfortable are you with making decisions that have open-ended answers? \n1 You perfer these decisions \n2 You are comfortable with making these decisions \n3 You are somewhat comfortable with these decisions \n4 You are not comfortable with these decisions",
        "Do you prefer brainstorming or creating pros and cons lists \n1 Brainstorming \n2 Both but I rely more on brainstorming \n3 Both but I rely more on pros and cons \n4 Pros and Cons"
    };

    protected override List<string> questions
    {
        get {
            return _questions;
        }
        set {
            _questions = value;
        }
    }
}

class Habits: Quiz {
    private List<string> _questions = new List<string>(){
        "\nDo you perfer stratigic games or games where you need to think outside of the box? \n1 answer \n2 answer \n3 answer \n4 answer",
        "\nQuestion2 \n1 answer \n2 answer \n3 answer \n4 answer",
        "\nQuestion3 \n1 answer \n2 answer \n3 answer \n4 answer",
        "\nQuestion4 \n1 answer \n2 answer \n3 answer \n4 answer"
    };
       protected override List<string> questions
    {
        get {
            return _questions;
        }
        set {
            _questions = value;
        }
    }
}

class Preferences: Quiz {
    private List<string> _questions = new List<string>(){
        "\nWhat kind of games do you like to play? \n1 Improv Games \n2 Word Association Games \n3 Problem Solving Games \n4 Strategic Games",
        "\nQuestion2 \n1 answer \n2 answer \n3 answer \n4 answer",
        "\nQuestion3 \n1 answer \n2 answer \n3 answer \n4 answer",
        "\nQuestion4 \n1 answer \n2 answer \n3 answer \n4 answer"
    };
       protected override List<string> questions
    {
        get {
            return _questions;
        }
        set {
            _questions = value;
        }
    }
}

class Strengths: Quiz {
    private List<string> _questions = new List<string>(){
        "\nStory telling \n1 answer \n2 answer \n3 answer \n4 answer",
        "\nQuestion2 \n1 answer \n2 answer \n3 answer \n4 answer",
        "\nQuestion3 \n1 answer \n2 answer \n3 answer \n4 answer",
        "\nQuestion4 \n1 answer \n2 answer \n3 answer \n4 answer"
    };
       protected override List<string> questions
    {
        get {
            return _questions;
        }
        set {
            _questions = value;
        }
    }
}

class Trivia: Quiz {
    private List<string> _questions = new List<string>(){
        "\nHow many sides does a circle have? \n1 Infinite \n2 Four \n3 One \n4 None",
        "\nThe next statement is false. The statement before is... \n1 True \n2 False \n3 Stupid \n4 Paradoxical",
        "\nCan you really experience something new if you had made expectations beforehand? \n1 No, expectations determine our perception \n2 Balancing expectaions and openess are important \n3 It depends on the person's mindset \n4 Yes, expectations are part of the experience",
        "\nCan a omnipotent being create a task that they cannot complete? \n1 Yes \n2 If they did, they would prove that they are omnipotent \n3 If they did, they would no longer be omnipotent \n4 No"
    };
       protected override List<string> questions
    {
        get {
            return _questions;
        }
        set {
            _questions = value;
        }
    }
}

class Emotions: Quiz {
    private List<string> _questions = new List<string>(){
        "\nAre you very aware of your emotions \n1 Yes \n2 Most of the time \n3 Sometimes \n4 No",
        "\nQuestion2 \n1 answer \n2 answer \n3 answer \n4 answer",
        "\nQuestion3 \n1 answer \n2 answer \n3 answer \n4 answer",
        "\nQuestion4 \n1 answer \n2 answer \n3 answer \n4 answer"
    };
       protected override List<string> questions
    {
        get {
            return _questions;
        }
        set {
            _questions = value;
        }
    }            
}
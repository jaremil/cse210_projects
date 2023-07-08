using System;

class Program {
    
    static void Main() {

        DecisionMaking decisionMaking = new DecisionMaking();
        Habits habits = new Habits();
        Preferences preferences = new Preferences();
        Strengths strengths = new Strengths();
        Trivia trivia = new Trivia();
        Emotions emotions = new Emotions();

        string startMessageDecisionMaking = "Decision Making Questionnaire: Desciption";
        string startmessageHabits = "Habits Questionnaire: Desciption";
        string startMessagePreferences = "Preferences Questionnaire: Desciption";
        string startMessageStrengths = "Strengths Questionnaire: Desciption";
        string startMessageTrivia = "Trivia Questionnaire: Desciption";
        string startMessageEmotions = "Emotions Questionnaire: Desciption";

        Console.Clear();
        Console.WriteLine("Welcome! This program will give you a series of questionnaires to determine if you think more logically or creatively.");
     
        List<string> history = new List<string>();

        string userInput = "";
        while (userInput != "7") {
            Console.WriteLine("\nPlease take each of these questionnaires once to recieve your results: \n1 Decision Making Questionnaire \n2 Habits Questionnaire \n3 Preferences Questionnaire \n4 Strengths Questionnaire \n5 Trivia Questionnaire \n6 Emotions Questionnaire \n7 End program");
            userInput = Console.ReadLine();

            if (userInput == "1"){
                Console.Clear();
                if (!history.Contains("1")){
                    history.Add("1");
                    Loading.LoadingAnimation(3);
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
                    Console.WriteLine(startMessageEmotions);
                    emotions.doActivity();
                }
                else{
                    Console.WriteLine("This test has already been finished.");
                }
            }
            Console.Clear();
        }

    }
}

// class Guess {
//     private bool _guess;
//         Guess (bool guess){
//             _guess = guess;
//         }
// }

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

class DecisionMaking {
    private int score = 0;
    private List<string> _decisions = new List<string>(){
        "When problem solving, do you focus on established guidelines and facts or do explore unconventional approaches and possibilities? \n1 I prefer to explore unconventional approaches and possibilities \n2 I focus more on finding new approaches but still keep the basic guidelines \n3 I rely on rules and facts to find new possibilities \n4 I perfer to focus on established rules and facts",
        "Is it easier for you to make a decision when given guidelines or when given freedom to think outside of the box? \n1 It is easier to make decisions when thinking outside the box \n2 It is easier to make decisions when given freedom to think outside the box with some guidelines \n3 It is easier to make decisions when given guidelines with some freedom to think outside the box \n4 It is easier to make decisions when given guidelines",
        "How comfortable are you with making decisions that have open-ended answers? \n1 You perfer these decisions \n2 You are comfortable with making these decisions \n3 You are somewhat comfortable with these decisions \n4 You are not comfortable with these decisions",
        "Do you prefer brainstorming or creating pros and cons lists \n1 Brainstorming \n2 Both but I rely more on brainstorming \n3 Both but I rely more on pros and cons \n4 Pros and Cons"
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
    private List<string> _habits = new List<string>(){
        "\nQuestion1 \n1 answer \n2 answer \n3 answer \n4 answer",
        "\nQuestion2 \n1 answer \n2 answer \n3 answer \n4 answer",
        "\nQuestion3 \n1 answer \n2 answer \n3 answer \n4 answer",
        "\\nQuestion4 \n1 answer \n2 answer \n3 answer \n4 answer"
    };

    public int returnScore(){
        return score;
    }
    public void doActivity(){

        foreach (string habit in _habits){
            Console.WriteLine(habit);
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
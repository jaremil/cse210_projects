using System;

class Program {
    static void Main() {

        var startmessageBreathing = new Startmessage("Welcome to the Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        var startmessageReflection = new Startmessage("Welcome to the Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        var startmessageListing = new Startmessage("Welcome to the Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        var endmessageBreathing = new Endmessage("You did a good job with your breathing!");
        var endmessageReflection = new Endmessage("Good job with your reflecting!");
        var endmessageListing = new Endmessage("That was a good list that you wrote!");

        ShowSpinner(5);
        Breath(8);

    }

    class Startmessage {
        protected string _introduction;
        protected string _description;

        public Startmessage(string introduction, string description){
            _introduction = introduction;
            _description = description;
        }
    }

    class Endmessage {
        protected string _endmessage;

        public Endmessage(string endmessage){
            _endmessage = endmessage;
        }
    }

    static void ShowSpinner(int duration) {

        List<string> animations = new List<string> {
            "-",
            "\\",
            "|",
            "/",
        };

        var startTime = DateTime.Now;
        var endTime = startTime.AddSeconds(duration);

        int animationIndex = 0;

        while(DateTime.Now < endTime) {
            string frame = animations[animationIndex];
            
            Console.Clear();
            Console.Write(frame);
            Thread.Sleep(250);
            Console.Write("\b \b");

            animationIndex++;
            if (animationIndex >= animations.Count) {
                animationIndex = 0;
            }
        }
    }

        static void Breath(int duration) {

        List<string> animations = new List<string> {
            "breath in",
            "breath in 1",
            "breath in 2",
            "breath in 3",
            "breath out",
            "breath out 1",
            "breath out 2",
            "breath out 3",
        };

        var startTime = DateTime.Now;
        var endTime = startTime.AddSeconds(duration);

        int animationIndex = 0;

        while(DateTime.Now < endTime) {
            string frame = animations[animationIndex];
            Console.Write(frame);
            Thread.Sleep(1000);
            Console.Clear();

            animationIndex++;
            if (animationIndex >= animations.Count) {
                animationIndex = 0;
            }
        }
    }

}
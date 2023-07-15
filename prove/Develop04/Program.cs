using System;

class Program {
    static void Main() {

        var startmessageBreathing = new Startmessage("Welcome to the Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        var startmessageReflection = new Startmessage("Welcome to the Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        var startmessageListing = new Startmessage("Welcome to the Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        var endmessageBreathing = new Endmessage("You did a good job focusing on your breathing!");
        var endmessageReflection = new Endmessage("Good job with your reflecting!");
        var endmessageListing = new Endmessage("Good job! That's a great list!");

        string userInput = "0";

        while (userInput != "4") {
            Console.Clear();
            Console.WriteLine("Please choose a mindfullness activity by inputing the corresponding number");
            Console.WriteLine("\n1. Breathing Activity");
            Console.WriteLine("2. Refection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit program");
            Console.Write("\nEnter number here: ");
            
            userInput = Console.ReadLine();

            if (userInput == "1")
            {
                
                Activity.ShowSpinner(5);
                Console.WriteLine($"{startmessageBreathing}");
                var breathing = new BreathingActivity(startmessageBreathing, endmessageBreathing);
                breathing.Breath();
                Console.WriteLine($"{endmessageBreathing}");
            }
            else if (userInput == "2")
            {
                Console.WriteLine(startmessageReflection);
                Activity.ShowSpinner(5);
                Activity.Countdown(7);
                Console.WriteLine(endmessageReflection);
            }
            else if (userInput == "3")
            {
                Console.WriteLine(startmessageListing);
                Activity.ShowSpinner(5);
                Activity.Countdown(7);
                Console.WriteLine(endmessageListing);
            }
        };
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

    // Parent class
    class Activity {
        Startmessage _startmessage;
        Endmessage _endmessage;
        protected int durtation = 27;

        public Activity(Startmessage startmessage, Endmessage endmessage){
            _startmessage = startmessage;
            _endmessage = endmessage;
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

        public static void ShowSpinner(int duration) {

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
    }

    class BreathingActivity:Activity {

        public BreathingActivity(Startmessage startmessage, Endmessage endmessage): base(startmessage, endmessage){

        }

        public void Breath() {

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
            var endTime = startTime.AddSeconds(durtation);

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
}
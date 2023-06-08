using System;

class Program {
    static void Main() {

        var descriptionBreathing = new Description("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        var descriptionReflection = new Description("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        var descriptionListing = new Description("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        var startmessageBreathing = new Startmessage("");
        var startmessageReflection = new Startmessage("");
        var startmessageListing = new Startmessage("");
        var endmessageBreathing = new Endmessage("");
        var endmessageReflection = new Endmessage("");
        var endmessageListing = new Endmessage("");

        ShowSpinner(5);
        Breath(8);

    }

    class Description {
        protected string _description;

        public Description(string description){
            _description = description;
        }
    }

    class Startmessage {
        protected string _startmessage;

        public Startmessage(string startmessage){
            _startmessage = startmessage;

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
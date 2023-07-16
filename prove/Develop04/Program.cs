using System;
class Program {
    static void Main() {

        var startmessageBreathing = new Startmessage("Welcome to the Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        var startmessageReflection = new Startmessage("Welcome to the Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        var startmessageListing = new Startmessage("Welcome to the Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        var endmessageBreathing = new Endmessage("You did a good job focusing on your breathing!");
        var endmessageReflection = new Endmessage("Good job with your reflecting!");
        var endmessageListing = new Endmessage("Good job! That's a great list!");

        var durationPrompt = "How many seconds would you like this activity to be? Please enter a number.";

        string userInput = "0";

        while (userInput != "4") {
            // FR1 & 5
            Console.WriteLine("Please choose a mindfullness activity by inputing the corresponding number");
            Console.WriteLine("\n1. Breathing Activity");
            Console.WriteLine("2. Refection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit program");
            Console.Write("\nEnter number here: ");
            
            userInput = Console.ReadLine();

            if (userInput == "1")
            {
                // begin
                Console.WriteLine($"{startmessageBreathing.showMessage()}");
                Thread.Sleep(5000);

                Console.WriteLine(durationPrompt);
                var duration = int.Parse(Console.ReadLine());
                
                Activity.ShowSpinner(5);
                
                // activity
                var breathing = new BreathingActivity(startmessageBreathing, endmessageBreathing);
                breathing.Breath(duration);

                // end
                Console.WriteLine($"{endmessageBreathing.showMessage()}");
                Thread.Sleep(5000);
            }
            else if (userInput == "2")
            {
                // begin
                Console.WriteLine($"{startmessageReflection.showMessage()}");
                Thread.Sleep(5000);

                Console.WriteLine(durationPrompt);
                var duration = int.Parse(Console.ReadLine());
                
                Activity.ShowSpinner(5);
                
                // activity
                var reflection = new Reflection(startmessageReflection, endmessageReflection);
                reflection.start(duration);

                // end
                Console.WriteLine($"{endmessageReflection.showMessage()}");
                Thread.Sleep(5000);
            }
            else if (userInput == "3")
            {
                // begin
                Console.WriteLine($"{startmessageListing.showMessage()}");
                Thread.Sleep(5000);

                Console.WriteLine(durationPrompt);
                var duration = int.Parse(Console.ReadLine());
                
                Activity.ShowSpinner(5);
                
                // activity
                var listing = new Listing(startmessageListing, endmessageListing);
                listing.theList(duration);

                // end
                Console.WriteLine($"{endmessageListing.showMessage()}");
                Thread.Sleep(5000);
            }
        }
    }

    // FR2: Start Message
    class Startmessage {
            protected string _introduction;
            protected string _description;

            public Startmessage(string introduction, string description){
                _introduction = introduction;
                _description = description;
            }

            public string showMessage() {
                return _introduction + _description;
            }
        }

    // FR3: end message
    class Endmessage {
            protected string _endmessage;

            public Endmessage(string endmessage){
                _endmessage = endmessage;
            }
            public string showMessage() {
                return _endmessage;
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

        // FR4: spinner animation
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

        public void Breath(int duration) {
            // loop
            var countup = 1;
            while (countup <= duration) {
                if (countup <= duration / 2) {
                    Console.WriteLine("breath in " + countup);
                } else {
                    Console.WriteLine("breath out " + countup);
                }
                countup += 1;
                Thread.Sleep(1000);
                Console.Clear();
            }
        }
    }

    class Reflection: Activity{
        public Reflection(Startmessage startmessage, Endmessage endmessage): base(startmessage, endmessage){}

        public void start(int duration) {
            var random = new Random();
            List<string> prompts = new List<string>{
                "Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless."
            };
            List<string> questions = new List<string>{
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?"
            };

            var countup = 1;
            var SINGLE_MESSAGE_DURATION = 10;

            while (countup <= duration) {
                // activity
                // print random prompt
                Console.WriteLine(prompts[random.Next(prompts.Count)]);
                // print random question
                Console.WriteLine(questions[random.Next(questions.Count)]);

                // overhead
                countup += SINGLE_MESSAGE_DURATION;
                // Thread.Sleep(SINGLE_MESSAGE_DURATION*1000);
                this.dotter(SINGLE_MESSAGE_DURATION);
                Console.Clear();
            }
        }

        public void dotter(int time) {
            for (int i = 0; i < time; i++)
            {
                Console.Write('.');
                Thread.Sleep(1000);
            }
        }
    }

    class Listing: Activity{
        public Listing(Startmessage startmessage, Endmessage endmessage): base(startmessage, endmessage){}
        
        
        List<string> prompt = new List<string>{
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        
        public void theList(int duration) {
            var random = new Random();
            Console.WriteLine(prompt[random.Next(prompt.Count)]);

            // initialize current time
            DateTime startTime = DateTime.Now;

            // calculate target end time
            DateTime futureTime = startTime.AddSeconds(duration);

            var count_list = 0;

            // loop
            while (DateTime.Now < futureTime) {
                Console.ReadLine();
                count_list += 1;
            }

            // print out count_list
            Console.WriteLine($"You were able to write {count_list} list items");
        }
    }
}
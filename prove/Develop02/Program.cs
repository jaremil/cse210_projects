using System.IO; 

class Program {

    /*
    Main:
    function options
    var input choices
    -Write Entry
    -Display Journal
    -Save Journal
    -Load Journal

    userinput
    if statement based on input
    */

    static void Main() {

        string userInput = "0";

        while (userInput != "5")
        {
            
            Console.WriteLine("Please choose from the options by inputing the corresponding number:");
            Console.WriteLine("1. Write new journal entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal entry");
            Console.WriteLine("4. Load journal");
            Console.WriteLine("5. End program");
            
            userInput = Console.ReadLine();

            if (userInput == "1")
            {
                // call Entry function

                // To write a new journal entry we need to 
                // * Give the user a prompt
                // * Give the user user input area to write in
                //  * Save the user's response to the prompt, the prompt, and the date

                PromptGenerator promptGenerator = new PromptGenerator();
                string prompt = promptGenerator.GetRandomPrompt();

                Console.WriteLine("Write your journal entry here:");
                string text = Console.ReadLine();

                // DateTime date = new DateTime();
                // date.Now.


                // string date = 

                // Entry entry = new Entry(text, prompt, date);
            }
            else if (userInput == "2")
            {
                // call 
            }
            else if (userInput == "3")
            {
                
            }
            else if (userInput == "4")
            {
                
            }
        };
    }

class Entry{

    // Attributes
    public string _text;
    public string _prompt;
    public string _date;
    public string displayEntry(){return "entry";}

    // Constructor
    public Entry(string text, string prompt, string date) {
        _text = text;
        _prompt = prompt;
        _date = date;
    }



}

class FileManager {

    public void SaveJournal (Journal journal, string filename) {
        using (StreamWriter outputFile = new StreamWriter(filename)) 
        {
            foreach (var entry in journal.listEntries)
            {
                string data = $"{entry._date};{entry._prompt};{entry._text}";
                outputFile.WriteLine(data);
            }
        }
    }

    public Journal LoadJournal(string file) {

        // string filename = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(file);

        // Copied from the instructions; doesn't work in this context
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string firstName = parts[0];
            string lastName = parts[1];
        }

        string[] Line = System.IO.File.ReadAllLines(file);
        Journal journal = new Journal();

        foreach (string line in lines){
            string[] parts = line.Split(";");

            string date = parts[0];
            string prompt = parts[1];
            string text = parts[2];

            // Entry entry = new Entry();
            // entry._date = date;
            // entry._prompt = prompt;
            // entry._text = text;

            // journal.listEntries.Add(entry);
        }

        return journal;
    }
}


class PromptGenerator {
    public List<String> _prompts;
    public PromptGenerator()
    {
        _prompts = new List<String> (){
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
    }

    public string GetRandomPrompt() {
        Random randomPrompt = new Random();
        int i = randomPrompt.Next(0,5);
        return _prompts[i];
    }
}

class Journal{
    public List<Entry> listEntries = new List<Entry>();
    public string displayEntryList(Entry entry){

        return "journal";
    }
}

}

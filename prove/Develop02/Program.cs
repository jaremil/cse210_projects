using System.IO; 

class Program{

    public int userInput = 0;


    static void Menu(int[] args) {

    }

}

class PromptGenerator{

    static void Prompt()
    {
        List<String> prompts = new List<String>{
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
    }

    static void Random(string[] arg) {
    Prompt();
    }
}

class Journal{
    public List<Entry> listEntries = new List<Entry>();
    public string displayEntryList(Entry entry){

    return "journal";
    }
}

class FileManager {

    public void SaveJournal (Journal journal, string filename) {
            using (StreamWriter outputFile = new StreamWriter(filename)) {
            foreach (var entry in journal.listEntries)
            {
                string data = $"{entry._date};{entry._prompt};{entry._text}";
                outputFile.WriteLine(data);
            }
        }
    }

    public Journal LoadJournal(string filename) {

        string filename = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string firstName = parts[0];
            string lastName = parts[1];
        }

        string[] lines = System.IO.File.ReadAllLines(filename);
        Journal journal = new Journal();

        foreach (string line in lines){
            string[] parts = line.Split(";");

            string date = parts[0];
            string prompt = parts[1];
            string text = parts[2];

            Entry entry = new Entry();
            entry._date = date;
            entry._prompt = prompt;
            entry._text = text;

            journal.listEntries.Add(entry);
        }

        return journal;
    }
}

class Entry{

    public string _text;
    public string _prompt;
    public string _date;

    public string displayEntry(){return "entry";}
}

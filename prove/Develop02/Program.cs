using System;

class Program{
    static void Menu(int[] args) {
    
    }

    public int userInput = 
}

class PromptGenorator{
    
   var prompts = new List<String> {
    
    };
        
    static void Random(string[] arg) {

    }
}

// displayEntryList(Entry):
// List<string>
class Journal{
    public List<Entry> listEntries = new List<Entry>();

    public string displayEntryList(Entry){

    }
}

class FileManager {

    public void SaveJournal (Journal journal, string filename) {
            using (StreamWriter outputFile = new StreamWriter(filename)) {
            foreach (var entry in journal._entries)
            {
                string data = $"{entry._date};{entry._prompt};{entry._text}"
                outputFile.WriteLine(data);
            }
        }
    }

    public Journal LoadJournal(string filename) {
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

            journal.entries.Add(entry);

            return journal;
        }
    }
}

// displayEntry(): string
class Entry{
    
    public string _text;
    public string _prompt;
    public string _date;
}
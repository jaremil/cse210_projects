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

            Entry entry = new Entry();
            entry._date = date;
            entry._prompt = prompt;
            entry._text = text;

            journal.listEntries.Add(entry);
        }

        return journal;
    }
}

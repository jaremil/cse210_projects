using System;

class Program {
    static void Main(string[] args) {

        string text = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.\n";

        string moreText = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.\n";

        Reference reference1 = new Reference("\nJohn", "3", "16");
        Scripture verse1 = new Scripture(reference1, text);

        Reference reference2 = new Reference("\nProverbs", "3", "5-6");
        Scripture verse2 = new Scripture(reference2, moreText);

        verse1.DisplayScripture();

        Console.WriteLine("\n Press 'enter' to change the amount of words displayed in the scripture.\n Type 'quit' before pressing 'enter' to end the program\n");

        // gets user input and does functions
        while (Console.ReadLine() != "quit")
        {
            Console.Clear();

            verse1.HideRandom();
            verse1.DisplayScripture();  

            Console.WriteLine("\n Press 'enter' to change the amount of words displayed in the scripture.\n Type 'quit' before pressing 'enter' to end the program.\n");

        }
    }
}

class Reference {
    // attribute
    string _name;
    string _chapter;
    string _verses;

    // constructor
    public Reference (string name, string chapter, string verses) {
        _name = name;
        _chapter = chapter;
        _verses = verses;
    }

    // method
    public void Display()  {

        Console.WriteLine(_name + " " + _chapter + ":" + _verses);

    }
}

class Scripture  {   // attribute
    Reference _reference;
    string _text;
    
    private List<Word> _words;

    // declares string of scripture (still thinking through this one)

    // constructor
    public Scripture(Reference reference, string text) {
        _reference = reference;
        _text = text;
        _words = new List<Word>();

        // splits string into strings per word
        string[] words = text.Split(" ");
        foreach (var w in words){
            var word0bj = new Word(w);
            _words.Add(word0bj);
        }
    }

    // method
    public void DisplayScripture()  {
        
        _reference.Display();

        foreach (var w in _words) {
            w.Display();
        }
    }

    public void HideRandom() {

        var random = new Random();

        _words[random.Next(_words.Count)].Hide();
        _words[random.Next(_words.Count)].Hide();
        _words[random.Next(_words.Count)].Hide();

    }
}

// Refferenced as w
class Word {
    // attribute
    string _letters;
    public bool _isHidden;

    // constructor
    public Word (string letterList) {
        _letters = letterList;
        _isHidden = false;
    }

    // method
    public void Display()  {

        Console.Write(" " + _letters);
    }

    public void Hide() {

        _letters = "___";
        _isHidden = true;
    }
}
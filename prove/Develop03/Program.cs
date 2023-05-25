using System;

class Program {
    static void Main(string[] args) {

        // gets user input
        Console.WriteLine("\n Press 'enter' to change the amount of words displayed in the scripture.\n Type 'quit' before pressing 'enter' to end the program.\n");

    }
}

class Reference {
    // attribute
    string _name;
    int _chapter;
    int _verses;

    // constructor
    public Reference (string name, int chapter, int verses) {
        _name = name;
        _chapter = chapter;
        _verses = verses;
    }

    // method
    void Display()  {

    }
}

class Scripture {
    // attribute
    Reference _reference;
    string _text;
    private List<Word> _words;

    // declares string of scripture (still thinking through this one)
    public string text = "!scripture here!";

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
    void DisplayScripture()  {

    }
}

class Word {
    // attribute
    string _letters;

    // constructor
    public Word (string wordList) {
        _letters = wordList;
    }

    // method
    void Display()  {

    }
}
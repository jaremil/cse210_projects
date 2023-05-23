using System;

class Program {
    static void Main(string[] args) {

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
    string _reference;
    string _verse;

    // constructor
    public Scripture (string reference, string verse) {
        _reference = reference;
        _verse = verse;
    }

    // method
    void DisplayScripture()  {

    }

    void Words() {

    }
}

class Word {
    // attribute
    List<string> _wordList;

    // constructor
    public Word (List<string> wordList) {
        _wordList = wordList;
    }

    // method
    void Display()  {

    }
}
using System;
class PromptGenerator {
    public List<String> _prompts;
    public void Prompt()
    {
        _prompts = new List<String> (){
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
    }

    void Random(string[] arg) {
        Prompt();
    }
}

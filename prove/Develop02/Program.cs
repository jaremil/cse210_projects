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
}
